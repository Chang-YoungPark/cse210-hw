using System;
using System.Collections.Generic;

// Order class
public class Order
{
    List<Product> _product;
    Customer _customer;

    public Order(List<Product> product, Customer customer)
    {
        _customer = customer;
        _product = product;
    }  

    // calculate total amount 
    public decimal GetTotalAmt()
    {
        decimal total = 0;
        int quantity = 0;
        decimal price = 0;
        foreach(Product item in _product)
        {
            quantity = item.GetQuantity();
            price = item.GetPrice();
            total += quantity * price;        
        }
        string flagUSA = _customer.GetCountry();
        if (flagUSA == "Y")
        {
            total += 5;
        }
        else 
        {
            total += 35;
        }

        return total;
    }
    
    // print Packing Label 
    public void PackingLabel()
    {
        string name = "";
        string prodID = "";
        int quantity = 0;
        int numProduct = 0;  
        decimal price = 0;
        Console.WriteLine("[ Packing List ]");  
        foreach(Product item in _product)
        {
            numProduct += 1;
            name = item.GetName();
            prodID = item.GetProductID();
            quantity = item.GetQuantity();            
            price = item.GetPrice();
            Console.WriteLine($"{numProduct}. Product ID: {prodID}, Product Name: {name}, Quantity: {quantity}, Price: {price}");      
        }       
        
        decimal amt = GetTotalAmt();
        Console.WriteLine($"Total Cost : {amt}");
        Console.WriteLine("");
    }

    // print Shipping Label 
    public void ShippingLabel()
    {
        string address = _customer.GetAddress();
        string name = _customer.GetName();   
        Console.WriteLine("[ Shipping List ]");
        Console.WriteLine($"Name : {name}");
        Console.WriteLine($"address : {address}");   
        Console.WriteLine("");              
    }
}
