using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        //  addresses
        Address address1 = new Address("123 Main St", "New York", "NY", "USA");
        Address address2 = new Address("456 Maple Ave", "Toronto", "ON", "Canada");

        // customers
        Customer customer1 = new Customer("Megan Martisano", address1);
        Customer customer2 = new Customer("Mia Villoso", address2);

        // products
        Product product1 = new Product("Smartphone", "A101", 1000.00m, 1);
        Product product2 = new Product("Power Bank", "B202", 25.50m, 2);
        Product product3 = new Product("Wireless Charger", "C303", 45.75m, 1);

        Product product4 = new Product("Office Chair", "D404", 200.00m, 1);
        Product product5 = new Product("Desk Lamp", "E505", 75.00m, 1);
        Product product6 = new Product("Keyboard", "F606", 47.75m, 1);
        
        // orders
        Order order1 = new Order(customer1);
        order1.AddProduct(product1);
        order1.AddProduct(product2);
        order1.AddProduct(product3);

        Order order2 = new Order(customer2);
        order2.AddProduct(product4);
        order2.AddProduct(product5);
        order2.AddProduct(product6);


        // Display order details
        Console.WriteLine("Order 1:");
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order1.GetTotalCost():0.00}");
        Console.WriteLine();

        Console.WriteLine("Order 2:");
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order2.GetTotalCost():0.00}");
    }
}