public class Address
{
  private string _address;
  private string _city;
  private string _province;
  private string _country;

  public Address(string address, string city, string province, string country)
  {
    _address = address;
    _city = city;
    _province = province;
    _country = country;
  }

  public string DisplayAddress()
  {
    string text = $"{_address}, {_city}, {_province}, {_country}";
    return text;
  }

  public bool CheckCitizen()
  {
    if (_country.ToLower() == "usa" || _country.ToLower() == "united states" || _country.ToLower() == "united states of america" )
    {
      return true;
    }
    return false;
  }
}