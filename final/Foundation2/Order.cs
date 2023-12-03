using System;
using System.Collections.Generic;
class Order
{
    private List<Product> _products;
    private Customer _customer;

    //  Below is the Constructor for creating an order
    public Order(Customer customer, List<Product> products)
    {
        _customer = customer;
        _products = products;
    }

    // Method to calculate the total cost of the order
    public double GetTotalCost()
    {
        double totalCost = 0;
        foreach (Product product in _products)
        {
            totalCost += product.GetPrice();
        }

        // Adds one-time shipping cost
        totalCost += _customer.IsInUSA() ? 5 : 35;

        return totalCost;
    }

    // Method to get the packing label
    public string GetPackingLabel()
    {
        string label = "";
        foreach (Product product in _products)
        {
            label += $"{product.GetName()} (ID: {product.GetProductId()})\n";
        }
        return label;
    }

    // Method to get the shipping label
    public string GetShippingLabel()
    {
        return $"{_customer.GetName()}\n{_customer.GetAddress().GetFullAddress()}";
    }

    // Override the ToString method to display the details of the order
    public override string ToString()
    {
        return $"{GetPackingLabel()}\n{GetShippingLabel()}\nTotal Cost: ${GetTotalCost()}";
    }
}