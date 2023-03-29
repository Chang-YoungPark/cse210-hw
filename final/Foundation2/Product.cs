using System;
using System.Collections.Generic;

// Product class
public class Product
{
    private string _name;
    private string _prodId;
    private decimal _price; 
    private int _quantity;
  
    public Product(string name, string prodId, decimal price, int quantity)
    {
        _name = name;
        _prodId = prodId;
        _price = price;
        _quantity = quantity;
    }  

    public string GetName()
    {
        return _name;
    }

    public string GetProductID()
    {
        return _prodId;
    }

    public decimal GetPrice()
    {
        return _price;
    }

    public int GetQuantity()
    {
        return _quantity;
    }

}
