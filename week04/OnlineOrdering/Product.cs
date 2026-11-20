class Product
{
    public string Name;
    public string ProductID;
    public double UnitPrice;
    public int Quantity;

    public Product(string name, string productID, double unitPrice, int quantity)
    {
        Name = name;
        ProductID = productID;
        UnitPrice = unitPrice;
        Quantity = quantity;
    }

    public double CalculateTotalCost()
    {
        return UnitPrice * Quantity;
    }
}