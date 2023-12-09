using System;
using System.Collections.Generic;
using System.Text;
class Program
{
    static void Main(string[] args)
    {
        // Example usage
        Address address1 = new Address("123 Main St", "Cityville", "CA", "USA");
        Customer customer1 = new Customer("Angelica Pickles", address1);

        List<Product> products1 = new List<Product>
        {
            new Product("Product 1 - Puzzle", "001", 10.99, 2),
            new Product("Product 2 - Sweater", "002", 24.99, 1),
            new Product("Product 3 - Chips", "003", 5.99, 3)
        };

        Order order1 = new Order(customer1, products1);

        Console.WriteLine("Order 1 Details:");
        order1.DisplayDetails(); // Call a method to display all details
        Console.WriteLine("\n----------------------\n");

        Address address2 = new Address("456 Oak St", "Townsville", "NY", "Canada");
        Customer customer2 = new Customer("Mickey & Minnie Mouse", address2);

        List<Product> products2 = new List<Product>
        {
            new Product("Product 4 - Picture Frame", "004", 15.49, 1),
            new Product("Product 5 - Jeans", "005", 32.99, 2)
        };

        Order order2 = new Order(customer2, products2);

        Console.WriteLine("Order 2 Details:");
        order2.DisplayDetails(); // Call a method to display all details
    }
}
//     {
//         // Create the address for customer1
//         Address address1 = new Address("123 Main St", "Cityville", "CA", "USA");
//         // Create customer1 with the address
//         Customer customer1 = new Customer("George Jetson", address1);
//         // Create products for order1
//         List<Product> products1 = new List<Product>
//         {
//             new Product("Product1", "001", 10.99, 2),
//             new Product("Product2", "002", 24.99, 1),
//             new Product("Product3", "003", 5.99, 3),
//         };
//         // Create order1 with customer1 and products1
//         Order order1 = new Order(customer1, products1);
//         // Display the details of order1
//         Console.WriteLine("Order 1 Details:");
//         Console.WriteLine(order1.ToString());
//         Console.WriteLine("\n----------------------\n");
//         // Below Creates the same as above only for customer 2
//         Address address2 = new Address("456 Oak St", "Townsville", "NY", "Canada");
//         Customer customer2 = new Customer("Angelica Pickles", address2);

//         List<Product> products2 = new List<Product>
//         {
//             new Product("Product4", "004", 15.49, 1),
//             new Product("Product5", "005", 32.99, 2),
//         };

//         Order order2 = new Order(customer2, products2);

//         Console.WriteLine("Order 2 Details:");
//         Console.WriteLine(order2.ToString());
//     }
// }