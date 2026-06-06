public class Product
{
  private string _productName;
  private string _productId;
  private double _price;
  private int _quantity;
  
public Product(string name, string id, double price, int quantity)
{
  _productName = name;
  _productId = id;
  _price = price;
  _quantity = quantity;
}

public string GetProductName()
{
  return _productName;
}

public string GetProductId()
{
  return _productId;
}

public double GetPrice()
{
  return _price;
}

public int GetQuantity()
{
  return _quantity;
}
public double DisplayTotalCost()
{
  double amount = (double)_price * _quantity;
  return amount;
}

}