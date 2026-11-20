class Product
{
    public string Name { get; set; }
    public string ProductID { get; set; }
    public double UnitPrice { get; set; }
    public int Quantity { get; set; }

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