using System;

public class Product
{
    private string _name;
    private string _id;
    private double _price;

    public Product(string name, string id, double price)
    {
        _name = name;
        _id = id;
        _price = price;
    }

    public string GetProductName()
    {
        return _name;
    }

    public string GetProductID()
    {
        return _id;
    }

    public double GetProductPrice()
    {
        return _price;
    }

    public void SetProductPrice(double price)
    {
        _price = price;
    }
}