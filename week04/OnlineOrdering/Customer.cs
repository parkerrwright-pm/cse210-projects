class Customer
{
    public string Name;
    public Address Address;

    public Customer(string name, Address address)
    {
        Name = name;
        Address = address;
    }

    public bool LivesInUSA()
    {
        return Address.IsInUSA();
    }

    public string GetShippingLabel()
    {
        return $"{Name}\n{Address.GetFullAddress()}";
    }
}