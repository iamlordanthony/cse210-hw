using System;

class Program
{
    static void Main(string[] args)
    {
        // Address & Customer 1 (USA)
        Address addr1 = new Address("123 Main St", "Dallas", "TX", "USA");
        Customer customer1 = new Customer("John Smith", addr1);

        // Order 1
        Order order1 = new Order(customer1);
        order1.AddProduct(new Product("Laptop", "LP123", 1000.00, 1));
        order1.AddProduct(new Product("Mouse", "MS456", 25.00, 2));

        // Address & Customer 2 (International)
        Address addr2 = new Address("77 King Road", "London", "Greater London", "UK");
        Customer customer2 = new Customer("Alice Walker", addr2);

        // Order 2
        Order order2 = new Order(customer2);
        order2.AddProduct(new Product("Tablet", "TB789", 400.00, 1));
        order2.AddProduct(new Product("Charger", "CH321", 20.00, 3));

        // Display Order 1
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order1.GetTotalPrice():0.00}\n");

        // Display Order 2
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order2.GetTotalPrice():0.00}");
    }
}
