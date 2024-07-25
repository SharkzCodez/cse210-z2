using System;
using System.Reflection.Metadata;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("1313 Lightning St", "Point Pleasant", "WV", "USA");
        Customer customer1 = new Customer("Jerry Brown", address1);

        Address address2 = new Address("756 Sturgeon Rd", "Manchester", "Northwestern England", "England");
        Customer customer2 = new Customer("Johnathan Brown", address2);

        Address address3 = new Address("3465 Dale Avenue", "Dallas", "TX", "USA");
        Customer customer3 = new Customer("James Brown", address3);
        //The customers are brothers, I've decided they're getting gifts to send to each other. Do not ask why I decided this as I do not know either and it shouldn't effect my grade. I just wanted you to know I think they're brothers

        Product product1 = new Product("Fishing Lure", 765456780, 4.49, 3);
        Product product2 = new Product("Cologne", 847612345, 32.99, 1);
        Product product3 = new Product("Wood Hatchet", 980257214, 24.99, 1);
        Product product4 = new Product("Football", 634987329, 13.69, 1);


        Order order1 = new Order();
        order1.Customer = customer1;
        order1.AddProduct(product1);
        order1.AddProduct(product2);

        Order order2 = new Order();
        order2.Customer = customer2;
        order2.AddProduct(product2);
        order2.AddProduct(product3);
        order2.AddProduct(product4);

        Order order3 = new Order();
        order3.Customer = customer3;
        order3.AddProduct(product1);
        order3.AddProduct(product2);
        order3.AddProduct(product4);

        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order1.GetCost():0.00}\n");

        Console.WriteLine();

        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order2.GetCost():0.00}");

        Console.WriteLine();

        Console.WriteLine(order3.GetPackingLabel());
        Console.WriteLine(order3.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order3.GetCost():0.00}");
    }
}