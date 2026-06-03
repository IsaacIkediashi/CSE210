public class Customer{
 private string _customerName;
 private Address _address;

 public Customer()
 {

 }
 
 public void SetCustomerName(string name)
 {
   _customerName = name;
 }

 public string GetCustomerName()
 {
    return _customerName;
 }

 public void SetCustomerAddress(string address, string city, string province, string country)
 {
    _address = new Address(address, city, province, country);
 }
 public string GetCustomerAddress()
 {
    return _address.DisplayAddress();
 }
 
 public bool CountryCheck()
 {
    return _address.CheckCitizen();
 }
 public string CustomerAddress()
 {
    if (!_address.CheckCitizen())
    {
      return $"Customer does not live in the united states";
    }
    return $"Customer lives in the united states";
 }
}