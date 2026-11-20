class Order
{
    private List<Product> _products;
    private Customer _customer;

    public List<Product> Products
    {
        get => _products;
        set => _products = value;
    }

    public Customer Customer
    {
        get => _customer;
        set => _customer = value;
    }

    public Order(Customer customer)
    {
        _customer = customer;
        _products = new List<Product>();
    }

    public void AddProduct(Product product)
    {
        Products.Add(product);
    }

    public double CalculateSubtotal()
    {
        double subtotal = 0;
        foreach (var product in Products)
        {
            subtotal += product.CalculateTotalCost();
        }
        return subtotal;
    }

    public double CalculateShippingCost()
    {
        return Customer.Address.IsInUSA() ? 5 : 35;
    }

    public double CalculateTotal()
    {
        return CalculateSubtotal() + CalculateShippingCost();
    }

    public string GeneratePackingLabel()
    {
        string label = "";
        foreach (var product in Products)
        {
            label += $"Name: {product.Name}\nProduct ID: {product.ProductID}\n\n";
        }
        return label;
    }

    public string GenerateShippingLabel()
    {
        return $"Name: {Customer.Name}\nAddress:\n{Customer.Address.GetFullAddress()}";
    }
}

