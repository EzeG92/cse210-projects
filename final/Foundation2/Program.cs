using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("123 Main St", "Springfield", "IL", "USA");
        Address address2 = new Address("456 Elm St", "Metropolis", "NY", "USA");
        Address address3 = new Address("789 Oak Ave", "London", "London", "United Kingdom");
        Address address4 = new Address("101 Pine St","Vancouver","BC","Canada");

        Customer customer1 = new Customer("John Doe", address1);
        Customer customer2 = new Customer("Jane Smith", address2);
        Customer customer3 = new Customer("Jim Brown", address3);
        Customer customer4 = new Customer("Jill Jones", address4);

        Product product1 = new Product("Watch", "W123", 80.50m, 2);
        Product product2 = new Product("Headphones", "H456", 10.00m, 2);
        Product product3 = new Product("Cellphone", "C789", 250m, 1);
        Product product4 = new Product("Speaker", "S321", 20m, 4);
        Product product5 = new Product("Laptop", "L456", 1000m, 1);
        Product product6 = new Product("Tablet", "T789", 500m, 2);

        Order order1 = new Order(customer1);
        order1.AddProduct(product1);
        order1.AddProduct(product2);
        order1.AddProduct(product5);

        Order order2 = new Order(customer2);
        order2.AddProduct(product3);
        order2.AddProduct(product4);
        order2.AddProduct(product6);

        Order order3 = new Order(customer3);
        order3.AddProduct(product5);
        order3.AddProduct(product6);
        order3.AddProduct(product2);

        Order order4 = new Order(customer4);
        order4.AddProduct(product1);
        order4.AddProduct(product6);
        order4.AddProduct(product3);

        ShowDetailOrder(order1);
        ShowDetailOrder(order2);
        ShowDetailOrder(order3);
        ShowDetailOrder(order4);
    }

    static void ShowDetailOrder(Order order)
    {
        Console.WriteLine("Packing Label");
        Console.WriteLine(order.PackingLabel());

        Console.WriteLine("Shipping Label");
        Console.WriteLine(order.ShippingLabel());

        Console.WriteLine($"Total Cost: ${order.GetTotalCostOrder()}");

        Console.WriteLine("-------------------------");
    }
}
