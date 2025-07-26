class Program
{
    static void Main()
    {
        // Order 1 (USA)
        Address address1 = new("123 Apple St", "Dallas", "TX", "USA");
        Customer customer1 = new("Alice Johnson", address1);
        Order order1 = new(customer1);
        order1.AddProduct(new Product("USB Cable", "P001", 3.99, 4));
        order1.AddProduct(new Product("Wireless Mouse", "P002", 15.50, 2));

        // Order 2 (International)
        Address address2 = new("456 Maple Ave", "Toronto", "ON", "Canada");
        Customer customer2 = new("Bob Smith", address2);
        Order order2 = new(customer2);
        order2.AddProduct(new Product("Bluetooth Speaker", "P003", 25.00, 1));
        order2.AddProduct(new Product("Laptop Stand", "P004", 40.00, 1));
        order2.AddProduct(new Product("HDMI Cable", "P005", 8.99, 2));

        List<Order> orders = new() { order1, order2 };

        foreach (var order in orders)
        {
            Console.WriteLine("=== PACKING LABEL ===");
            Console.WriteLine(order.GetPackingLabel());
            Console.WriteLine("\n=== SHIPPING LABEL ===");
            Console.WriteLine(order.GetShippingLabel());
            Console.WriteLine($"\nTotal Cost: ${order.GetTotalCost():0.00}");
            Console.WriteLine(new string('-', 40));
        }
    }
}
