using System.Net.Http.Headers;

public class Order
{
  private List<Product> _products;
  private Customer _customer;

  public Order()
  {
    _products = new List<Product>();
    _customer = new Customer();
  }
  
  public void SetCustomerName(string name)
  {
    _customer.SetCustomerName(name);
  }
  public void SetProducts(string name, string id, double price, int quantity)
  {
    _products.Add(new Product(name, id, price, quantity));
  }
  public List<Product> GetProducts()
  {
    return _products;
  }
  public double CalculateTotalCost()
  { 
    double _total = 0;
    
    foreach(Product product in _products)
    {
      _total += product.DisplayTotalCost(); 
    }


    if (_customer.CountryCheck())
    {
      return _total += 5;
    }
     
    return _total += 35;
  }
  public string PackingLabel(int index)
  {
      int i = index;
      string name = _products[i].GetProductName(); 
      string id = _products[i].GetProductId();
      
      return $"{name}: {id}";
  }
  public string ShippingLabel(string address, string city, string province, string country)
  {
    _customer.SetCustomerAddress(address, city, province, country);
    return $"{_customer.GetCustomerName()} - {_customer.GetCustomerAddress()}"; 
  }
}