using System;
using System.Diagnostics;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Console.WriteLine("Hello World! This is the OnlineOrdering Project.\n");
        // declaring the variables
        string aCustomer;
        Address theAddress;
        string street;
        string city;
        string state;
        string country;
        int id;
        string productName;
        int quantity;
        double price;
        List<Order> orders = new List<Order>();

        // Record products
        id = 1;
        productName = "Laptop Dell";
        quantity = 10;
        price = 2000;
        Product product1 = new Product(id, productName, quantity, price);
        id = 2;
        productName = "Laptop Lenovo";
        quantity = 20;
        price = 1850;
        Product product2 = new Product(id, productName, quantity, price);
        id = 3;
        productName = "Honor 8xd";
        quantity = 25;
        price = 360;
        Product product3 = new Product(id, productName, quantity, price);
        id = 4;
        productName = "Samsung A17";
        quantity = 30;
        price = 390;
        Product product4 = new Product(id, productName, quantity, price);
        id = 5;
        productName = "Iphone 10";
        quantity = 15;
        price = 550;
        Product product5 = new Product(id, productName, quantity, price);

        // record the orders
        aCustomer = "John Smith";
        street = "Lincoln Street 123";
        city = "Los Angeles";
        state = "CA";
        country = "usa";
        theAddress = new Address(street, city, state, country);
        Order order1 = new Order(aCustomer, theAddress);
        // add the product 1
        order1.SetProduct(product1);
        // add the product 3
        order1.SetProduct(product3);
        // add the product 4
        order1.SetProduct(product4);
        orders.Add(order1);
        
        aCustomer = "Vaughn Poulson";
        street = "Pioneers Street 10";
        city = "Medford";
        state = "OR";
        country = "United States";
        theAddress = new Address(street, city, state, country);
        Order order2 = new Order(aCustomer, theAddress);
        // add the product 2
        order2.SetProduct(product2);
        // add the product 5
        order2.SetProduct(product5);
        orders.Add(order2);

        aCustomer = "Henry Zubieta";
        street = "Juan Rocha Street";
        city = "Santa Cruz";
        state = "SC";
        country = "Bolivia";
        theAddress = new Address(street, city, state, country);
        Order order3 = new Order(aCustomer, theAddress);
        // add the product 2
        order3.SetProduct(product2);
        // add the product 5
        order3.SetProduct(product5);
        orders.Add(order3);
        // now to show
        foreach (Order item in orders)
        {
            Console.WriteLine($"Shipping label:\n{item.GetShippingLabel()}");
            Console.WriteLine($"Total price is: ${item.GetTotalPrice()}");
            Console.WriteLine();
        }
    }
}