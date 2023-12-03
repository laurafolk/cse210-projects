using System;
using System.Collections.Generic;
class Product
{
    private string _name;
    private string _productId;
    private double _price;
    private int _quantity;

    // Below is the Constructor for creating a product
    public Product(string name, string productId, double price, int quantity)
    {
        _name = name;
        _productId = productId;
        _price = price;
        _quantity = quantity;
    }

    // Method to get the product name
    public string GetName() => _name;
    // Method to get the product ID
    public string GetProductId() => _productId;
    // Method to calculate the total price of the product
    public double GetPrice() => _price * _quantity;

    // Override the ToString method to display the details of the product                           
    public override string ToString()
    {
        return $"{_name} (ID: {_productId}) - Price: ${_price}, Quantity: {_quantity}";
    }
}