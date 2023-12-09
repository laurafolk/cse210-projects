using System;
using System.Collections.Generic;
class Customer
{
    private string _name;
    private Address _address;

    // Constructor creating a customer with a name and address
    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }

    // Method to get the customer name
    public string GetName() => _name;

    // Method to get the customer address
    public Address GetAddress() => _address;

    // Method checking if the customer lives in the USA or not
    public bool IsInUSA() => _address.IsInUSA();

    //ToString method to display the details of the customer
    public override string ToString()
    {
        return $"{_name}\n{_address.ToString()}";
    }
}
// Keep everything below just in case needed at all.
// class Customer
// {
//     private string _name;
//     private Address _address;
//     // Constructor for creating a customer
//     public Customer(string name, Address address)
//     {
//         _name = name;
//         _address = address;
//     }
//     // Method to get the customer name
//     public string GetName() => _name;
//     // Method to get the customer address
//     public Address GetAddress() => _address;
//     // Method to check if the customer lives in the USA or not
//     public bool IsInUSA() => _address.IsInUSA();
//     // Override the ToString method to display the details of the customer
//     public override string ToString()
//     {
//         return $"{_name}\n{_address.GetFullAddress()}";
//     }
// }