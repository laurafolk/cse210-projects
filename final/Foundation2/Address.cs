using System;
using System.Collections.Generic;
class Address
{
    private string _streetAddress;
    private string _city;
    private string _state;
    private string _country;

    // Constructor to create an address with specified attributes
    public Address(string streetAddress, string city, string state, string country)
    {
        _streetAddress = streetAddress;
        _city = city;
        _state = state;
        _country = country;
    }

    // Method to check if the address is in the USA
    public bool IsInUSA() => _country.ToUpper() == "USA";

    // Override the ToString method to return all fields as a formatted string
    public override string ToString()
    {
        return $"{_streetAddress}\n{_city}, {_state}\n{_country}";
    }
}
// Keep everything below just in case needed at all
// class Address
// {
//     private string _streetAddress;
//     private string _city;
//     private string _state;
//     private string _country;

//     public Address(string streetAddress, string city, string state, string country)
//     {
//         _streetAddress = streetAddress;
//         _city = city;
//         _state = state;
//         _country = country;
//     }
//     // Below is the Constructor for creating an address
//     public bool IsInUSA() => _country.ToUpper() == "USA";

//     public string GetFullAddress()
//     {
//          return $"{_streetAddress}\n{_city}, {_state}\n{_country}";
//     }

//     public override string ToString()
//     {
//         return $"{_streetAddress}\n{_city}, {_state}\n{_country}";
//     }
// }