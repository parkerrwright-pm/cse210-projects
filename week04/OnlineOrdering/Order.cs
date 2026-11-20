class Order
{
    public List<Product> Products;
    public Customer Customer;

    public Order(Customer customer)
    {
        Customer = customer;
        Products = new List<Product>();
    }
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

