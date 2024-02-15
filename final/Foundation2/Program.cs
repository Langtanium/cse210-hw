using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("Calle 11 Ruiz", "Ensenada", "Baja California", "Mexico");
        Customer customer1 = new Customer("Marco Polo", address1);
        List<Product> productList1 = new List<Product>()
        {
            new Product("Sonic Nendoroid", "0145839571", 24),
            new Product("Kirby Nendoroid", "9366824852", 22)
        };
        Order order1 = new Order(productList1, customer1);
        order1.DisplayPackagingLabel();
        Console.WriteLine($"Total: ${order1.GetTotalCost()}");
        Console.WriteLine();
        order1.DisplayShippingLabel();

        Console.WriteLine();
        Console.WriteLine();

        Address address2 = new Address("11643 Ruthelen St", "Los Angeles", "California", "USA");
        Customer customer2 = new Customer("Dori Stormer", address2);
        List<Product> productList2 = new List<Product>()
        {
            new Product("Nail Polish", "1188462054", 10),
            new Product("Nail Polish Remover", "6767400715", 12),
            new Product("Brush", "7654091254", 15)
        };
        Order order2 = new Order(productList2, customer2);
        order2.DisplayPackagingLabel();
        Console.WriteLine($"Total: ${order2.GetTotalCost()}");
        Console.WriteLine();
        order2.DisplayShippingLabel();
    }
}