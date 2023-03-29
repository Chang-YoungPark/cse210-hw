using System;
using System.Collections.Generic;

// Customer class
public class Customer
{
    private string _name;
    private string _flagUSA;
    Address _address;

    // Constructor 
    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }  

    // Get name
    public string GetName()
    {
        return _name;
    }
    
    // Get Whether it is in the USA or not
    public string GetCountry()
    {
        _flagUSA = _address.GetliveArea();
        return _flagUSA;
    }

    // Get Address
    public string GetAddress()
    {
        string address  = _address.GetfieldAddress();
        return address;
    }

}
