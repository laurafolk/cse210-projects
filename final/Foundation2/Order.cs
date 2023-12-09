using System;
using System.Collections.Generic;
using System.Text;
class Order
{
    private List<Product> _products;
    private Customer _customer;

    // Constructor to create an order with a customer and products
    public Order(Customer customer, List<Product> products)
    {
        _customer = customer;
        _products = products;
    }

    // Method to display all details of the order
    public void DisplayDetails()
    {
        // Use StringBuilder for efficient string concatenation
        StringBuilder orderDetailsBuilder = new StringBuilder();

        // Packing Label
        orderDetailsBuilder.AppendLine("Packing Label:");
        orderDetailsBuilder.AppendLine(GetPackingLabel());

        // Shipping Label
        orderDetailsBuilder.AppendLine("\nShipping Label:");
        orderDetailsBuilder.AppendLine(GetShippingLabel());

        // Total Cost
        orderDetailsBuilder.AppendLine($"\nTotal Cost: ${GetTotalCost()}");

        // Display the combined details
        Console.WriteLine(orderDetailsBuilder.ToString());
    }

    // Method to get the packing label
    public string GetPackingLabel()
    {
        // Use StringBuilder for efficient string concatenation
        StringBuilder labelBuilder = new StringBuilder();
        foreach (Product product in _products)
        {
            labelBuilder.AppendLine($"{product.GetName()} (ID: {product.GetProductId()}), Quantity: {product.GetQuantity()}, Total Price: ${product.GetTotalPrice()}");
        }
        return labelBuilder.ToString();
    }

    // Method to get the shipping label
    public string GetShippingLabel()
    {
        // Use StringBuilder for efficient string concatenation
        StringBuilder shippingLabelBuilder = new StringBuilder();
        shippingLabelBuilder.AppendLine($"{_customer.GetName()}");
        shippingLabelBuilder.AppendLine($"{_customer.GetAddress().ToString()}");
        return shippingLabelBuilder.ToString();
    }

    // Method to calculate the total cost
    public double GetTotalCost()
    {
        double totalCost = 0;
        foreach (Product product in _products)
        {
            totalCost += product.GetPrice();
        }

        // Add one-time shipping cost
        totalCost += _customer.IsInUSA() ? 5 : 35;

        return totalCost;
    }
}
// Keep everything below this just in case needed at any point.
// class Order
// {
//     private List<Product> _products;
//     private Customer _customer;

//     //  Below is the Constructor for creating an order
//     public Order(Customer customer, List<Product> products)
//     {
//         _customer = customer;
//         _products = products;
//     }

//     // Method to calculate the total cost of the order
//     public double GetTotalCost()
//     {
//         double totalCost = 0;
//         foreach (Product product in _products)
//         {
//             totalCost += product.GetPrice();
//         }

//         // Adds one-time shipping cost
//         totalCost += _customer.IsInUSA() ? 5 : 35;

//         return totalCost;
//     }

//     // Method to get the packing label
//     public string GetPackingLabel()
//     {
//         string label = "";
//         foreach (Product product in _products)
//         {
//             label += $"{product.GetName()} (ID: {product.GetProductId()})\n";
//         }
//         return label;
//     }

//     // Method to get the shipping label
//     public string GetShippingLabel()
//     {
//         return $"{_customer.GetName()}\n{_customer.GetAddress()}";
//     }

//     // Override the ToString method to display the details of the order
//     public override string ToString()
//     {
//         return $"{GetPackingLabel()}\n{GetShippingLabel()}\nTotal Cost: ${GetTotalCost()}";
//     }
// }