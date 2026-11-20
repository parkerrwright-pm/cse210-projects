using System;

class Program
{
    static void Main(string[] args)
    {
        // Create addresses
        Address address1 = new Address("123 Main St", "Provo", "UT", "USA");
        Address address2 = new Address("456 Elm St", "Toronto", "ON", "Canada");

        // Create customers
        Customer customer1 = new Customer("John Doe", address1);
        Customer customer2 = new Customer("Jane Smith", address2);

        // Create products
        Product product1 = new Product("Laptop", "P001", 999.99, 1);
        Product product2 = new Product("Mouse", "P002", 25.50, 2);
        Product product3 = new Product("Keyboard", "P003", 45.00, 1);
        Product product4 = new Product("Monitor", "P004", 150.00, 1);

        // Create orders
        Order order1 = new Order(customer1);
        order1.AddProduct(product1);
        order1.AddProduct(product2);

        Order order2 = new Order(customer2);
        order2.AddProduct(product3);
        order2.AddProduct(product4);

        // Display order details
        Console.WriteLine("Order 1 Packing Label:");
        Console.WriteLine(order1.GeneratePackingLabel());
        Console.WriteLine("Order 1 Shipping Label:");
        Console.WriteLine(order1.GenerateShippingLabel());
        Console.WriteLine($"Order 1 Total: ${order1.CalculateTotal()}\n");

        Console.WriteLine("Order 2 Packing Label:");
        Console.WriteLine(order2.GeneratePackingLabel());
        Console.WriteLine("Order 2 Shipping Label:");
        Console.WriteLine(order2.GenerateShippingLabel());
        Console.WriteLine($"Order 2 Total: ${order2.CalculateTotal()}");
    }
}