using System;
using System.Collections.Generic;

// Address class
public class Address
{
    private string _street;
    private string _city;
    private string _state;
    private string _country;
    private string _zip; 
    private string _address; 
  
    public Address(string street, string city, string state, string country, string zip)
    {
        _street = street;
        _city = city;
        _state = state;
        _country = country;
        _zip = zip;
    }  


    // Get Address of Customer 
    public string GetfieldAddress()
    {
        _address = $"{_street}, {_city}, {_state}, {_country}, {_zip}";
        return _address;
    }

}
