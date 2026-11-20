class Product
{
    private string _name;
    private string _productID;
    private double _unitPrice;
    private int _quantity;

    public string Name
    {
        get => _name;
        set => _name = value;
    }

    public string ProductID
    {
        get => _productID;
        set => _productID = value;
    }

    public double UnitPrice
    {
        get => _unitPrice;
        set => _unitPrice = value;
    }

    public int Quantity
    {
        get => _quantity;
        set => _quantity = value;
    }

    public Product(string name, string productID, double unitPrice, int quantity)
    {
        _name = name;
        _productID = productID;
        _unitPrice = unitPrice;
        _quantity = quantity;
    }

    public double CalculateTotalCost()
    {
        return UnitPrice * Quantity;
    }
}