using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("123 Main St", "Springfield", "IL", "USA");
        Customer customer1 = new Customer("John Doe", address1);
        Order order1 = new Order(customer1);
        order1.AddProduct(new Product("Bluetooth Headphones", "A123", 25.5, 2));
        order1.AddProduct(new Product("Wireless Mouse", "B456", 15, 1));

        Address address2 = new Address("456 Elm Ave", "Toronto", "ON", "Canada");
        Customer customer2 = new Customer("Jane Smith", address2);
        Order order2 = new Order(customer2);
        order2.AddProduct(new Product("USB-C Cable", "C789", 8.0, 3));
        order2.AddProduct(new Product("Webcam", "D101", 32.99, 1));
        order2.AddProduct(new Product("Laptop Stand", "E202", 18.5, 2));

        List<Order> orders = new List<Order> { order1, order2 };
        int orderNumber = 1;
        foreach (var order in orders)
        {
            Console.WriteLine($"Order {orderNumber}:");
            Console.WriteLine(order.GetPackingLabel());
            Console.WriteLine(order.GetShippingLabel());
            Console.WriteLine($"Total Price: ${order.GetTotalPrice():0.00}");
            Console.WriteLine(new string('-', 40));
            orderNumber++;
        }
    }
}
