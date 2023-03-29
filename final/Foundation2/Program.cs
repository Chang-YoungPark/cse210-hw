using System;

class Program
{
    static void Main(string[] args)
    {
        // Address  
        Address address = new Address( "123 Main St", "Saltlake", "UT", "USA", "12345" );
        // Customer 
        Customer customer = new Customer( "Alma Smith", address );           
        
        // Product 
        List<Product> product = new List<Product>();
        Product product1 = new Product("Product1", "P1", 15, 2 );
        Product product2 = new Product("Product2", "P2", 20, 3 );
        product.Add(product1);
        product.Add(product2);
           
        // Order    
        Order order = new Order(product, customer);

        order.PackingLabel();
        order.ShippingLabel();
    }
}