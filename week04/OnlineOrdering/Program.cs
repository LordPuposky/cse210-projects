using System;
using System.Collections.Generic;

// Address class
public class Address
{
    private string street;
    private string city;
    private string stateOrProvince;
    private string country;

    public Address(string street, string city, string stateOrProvince, string country)
    {
        this.street = street;
        this.city = city;
        this.stateOrProvince = stateOrProvince;
        this.country = country;
    }

    public bool IsInUSA()
    {
        return country.Trim().ToUpper() == "USA";
    }

    public string GetAddressString()
    {
        return $"{street}\n{city}, {stateOrProvince}\n{country}";
    }
}

// Customer class
public class Customer
{
    private string name;
    private Address address;

    public Customer(string name, Address address)
    {
        this.name = name;
        this.address = address;
    }

    public string Name
    {
        get { return name; }
    }

    public Address Address
    {
        get { return address; }
    }

    public bool LivesInUSA()
    {
        return address.IsInUSA();
    }
}

// Product class
public class Product
{
    private string name;
    private string productId;
    private double price;
    private int quantity;

    public Product(string name, string productId, double price, int quantity)
    {
        this.name = name;
        this.productId = productId;
        this.price = price;
        this.quantity = quantity;
    }

    public string Name
    {
        get { return name; }
    }

    public string ProductId
    {
        get { return productId; }
    }

    public double Price
    {
        get { return price; }
    }

    public int Quantity
    {
        get { return quantity; }
    }

    public double GetTotalCost()
    {
        return price * quantity;
    }
}

// Order class
public class Order
{
    private List<Product> products;
    private Customer customer;

    public Order(Customer customer)
    {
        this.customer = customer;
        products = new List<Product>();
    }

    public void AddProduct(Product product)
    {
        products.Add(product);
    }

    public double GetTotalPrice()
    {
        double total = 0;
        foreach (var product in products)
        {
            total += product.GetTotalCost();
        }
        total += customer.LivesInUSA() ? 5.0 : 35.0;
        return total;
    }

    public string GetPackingLabel()
    {
        string label = "Packing Label:\n";
        foreach (var product in products)
        {
            label += $"{product.Name} (ID: {product.ProductId})\n";
        }
        return label;
    }

    public string GetShippingLabel()
    {
        string label = "Shipping Label:\n";
        label += customer.Name + "\n";
        label += customer.Address.GetAddressString();
        return label;
    }
}

class Program
{
    static void Main(string[] args)
    {
        // First customer and order (USA)
        Address address1 = new Address("123 Main St", "Springfield", "IL", "USA");
        Customer customer1 = new Customer("John Doe", address1);
        Order order1 = new Order(customer1);

        Product product1 = new Product("Bluetooth Headphones", "A123", 25.5, 2);
        Product product2 = new Product("Wireless Mouse", "B456", 15, 1);
        order1.AddProduct(product1);
        order1.AddProduct(product2);

        // Second customer and order (International)
        Address address2 = new Address("456 Elm Ave", "Toronto", "ON", "Canada");
        Customer customer2 = new Customer("Jane Smith", address2);
        Order order2 = new Order(customer2);

        Product product3 = new Product("USB-C Cable", "C789", 8.0, 3);
        Product product4 = new Product("Webcam", "D101", 32.99, 1);
        order2.AddProduct(product3);
        order2.AddProduct(product4);

        // Display the information for both orders
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
