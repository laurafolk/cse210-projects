using System;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {
        // Create the address for customer1
        Address address1 = new Address("123 Main St", "Cityville", "CA", "USA");
        // Create customer1 with the address
        Customer customer1 = new Customer("John Doe", address1);
        // Create products for order1
        List<Product> products1 = new List<Product>
        {
            new Product("Product1", "001", 10.99, 2),
            new Product("Product2", "002", 24.99, 1),
            new Product("Product3", "003", 5.99, 3)
        };
        // Create order1 with customer1 and products1
        Order order1 = new Order(customer1, products1);
        // Display the details of order1
        Console.WriteLine("Order 1 Details:");
        Console.WriteLine(order1.ToString());
        Console.WriteLine("\n----------------------\n");
        // Below Creates the same as above only for customer 2
        Address address2 = new Address("456 Oak St", "Townsville", "NY", "Canada");
        Customer customer2 = new Customer("Jane Smith", address2);

        List<Product> products2 = new List<Product>
        {
            new Product("Product4", "004", 15.49, 1),
            new Product("Product5", "005", 32.99, 2)
        };

        Order order2 = new Order(customer2, products2);

        Console.WriteLine("Order 2 Details:");
        Console.WriteLine(order2.ToString());
    }
}