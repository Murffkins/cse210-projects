using System;

// Make sure that all member variables are private and getters, setters, and constructors are created as needed.

class Program
{
    static void Main(string[] args)
    {
        Console.BackgroundColor = ConsoleColor.DarkBlue;
        Console.ForegroundColor = ConsoleColor.White;


        // Once you have created the classes, write a program that creates at least two orders with a 2-3 products each.
        Address address1 = new Address("123 Bugscuffle Lane", "Lavaca", "Arkansas", "USA");
        Customer customer1 = new Customer("Starla Flagpants", address1);
        Order order1 = new Order(customer1);
        Product product1 = new Product("Pimple Popper", 137897, 1.25, 1);
        Product product2 = new Product("Flashlight", 845930, 10.99, 1);
        Product product3 = new Product("Grapes", 374739, 2.65, 1);
        order1.CreateProductList(product1);
        order1.CreateProductList(product2);
        order1.CreateProductList(product3);

        Address address2 = new Address("456 Knightrider Street", "Maidstone", "Kent", "England");
        Customer customer2 = new Customer("Fanny Bogtrotter", address2);
        Order order2 = new Order(customer2);
        Product product4 = new Product("Biscuits", 367413, 3.99, 2);
        Product product5 = new Product("Rubbish bin", 285324, 12.99, 1);
        Product product6 = new Product("Crisps", 852735, 3.99, 3);
        order2.CreateProductList(product4);
        order2.CreateProductList(product5);
        order2.CreateProductList(product6);


        // Call the methods to get the packing label, the shipping label, and the total price of the order, and display the results of these methods.
        Console.WriteLine("Order 1");
        Console.WriteLine("<quantity> Product Name(ID)");
        Console.WriteLine($"{order1.PackingLabel()}");
        Console.WriteLine("Shipping Information");
        Console.WriteLine($"{order1.ShippingLabel()}");
        Console.WriteLine($"Total Amount: {order1.GetOrderCost()}");
        Console.WriteLine("");

        Console.WriteLine("########################################################################");
        Console.WriteLine("");

        Console.WriteLine("Order 2");
        Console.WriteLine("<quantity> Product Name(ID)");
        Console.WriteLine($"{order2.PackingLabel()}");
        Console.WriteLine("Shipping Information");
        Console.WriteLine($"{order2.ShippingLabel()}");
        Console.WriteLine("");
        Console.WriteLine($"Total Amount: ${order2.GetOrderCost()}");
        Console.WriteLine("");
    }
}