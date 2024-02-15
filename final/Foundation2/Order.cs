using System;
using System.Collections.Generic;

public class Order
{
    private List<Product> _products = new List<Product>();
    private Customer _customer;

    public Order(List<Product> products, Customer customer)
    {
        _products = products;
        _customer = customer;
    }

    public double GetTotalCost()
    {
        double totalCost = GetShippingCost();
        foreach (Product product in _products)
        {
            totalCost += product.GetProductPrice();
        }
        return totalCost;
    }

    public double GetShippingCost()
    {
        bool inUSA = _customer.InUSA();
        if (inUSA)
        {
            return 5;
        }
        else
        {
            return 35;
        }
    }

    public void DisplayPackagingLabel()
    {
        Console.WriteLine("Products:");
        foreach (Product product in _products)
        {
            string productName = product.GetProductName();
            string productID = product.GetProductID();
            Console.WriteLine($"  {productName} - {productID}");
        }
    }

    public void DisplayShippingLabel()
    {
        Console.WriteLine(_customer.GetCustomerName());
        Console.WriteLine(_customer.GetCustomerAddress());
    }
}