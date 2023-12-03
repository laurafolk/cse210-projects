using System;
using System.Collections.Generic;
class Address
{
    private string _streetAddress;
    private string _city;
    private string _state;
    private string _country;

    public Address(string streetAddress, string city, string state, string country)
    {
        _streetAddress = streetAddress;
        _city = city;
        _state = state;
        _country = country;
    }
    // Below is the Constructor for creating an address
    public bool IsInUSA() => _country.ToUpper() == "USA";

    public string GetFullAddress()
    {
        return $"{_streetAddress}\n{_city}, {_state}\n{_country}";
    }

    public override string ToString()
    {
        return GetFullAddress();
    }
}