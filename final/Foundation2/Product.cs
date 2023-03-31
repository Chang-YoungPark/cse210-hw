using System;
using System.Collections.Generic;

// Product class
public class Product
{
    private string _name;
    private string _prodId;
    private decimal _price; 
    private int _quantity;
  
    // Constructor
    public Product(string name, string prodId, decimal price, int quantity)
    {
        _name = name;
        _prodId = prodId;
        _price = price;
        _quantity = quantity;
    }  

    // Get product name
    public string GetName()
    {
        return _name;
    }
   
    // Get product ID
    public string GetProductID()
    {
        return _prodId;
    }
    
    // Get Price
    public decimal GetPrice()
    {
        return _price;
    }
   
    // Get Quantity
    public int GetQuantity()
    {
        return _quantity;
    }

}
