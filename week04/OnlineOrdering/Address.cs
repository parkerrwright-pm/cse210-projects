class Address
{
    public string StreetAddress;
    public string City;
    public string StateOrProvince;
    public string Country;

    public Address(string streetAddress, string city, string stateOrProvince, string country)
    {
        StreetAddress = streetAddress;
        City = city;
        StateOrProvince = stateOrProvince;
        Country = country;
    }

    public bool IsInUSA()
    {
        return Country == "USA";
    }

    public string GetFullAddress()
    {
        return $"{StreetAddress}\n{City}, {StateOrProvince}\n{Country}";
    }
}