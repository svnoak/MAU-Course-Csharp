using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Title = "My first C# Prorgam";
        Console.BackgroundColor = ConsoleColor.Blue;
        Console.ForegroundColor = ConsoleColor.White;
        Console.Clear();

        Product product = new Product();
        product.ReadName();

        Console.WriteLine();
        product.ReadPrice();

        Console.WriteLine();
        product.ReadCount();

        Console.WriteLine();
        product.CalculateTotalPrice();

        Console.WriteLine("Press Enter to exit!");
        Console.ReadLine();
    }
}

class Product
{
    private string name;
    private double price;
    private int count;

    public void ReadName()
    {
        Console.WriteLine("Name of the product?");
        name = Console.ReadLine();
        Console.WriteLine("The product's name is " + name);
    }

    public void ReadPrice()
    {
        Console.WriteLine("Price of the product?");
        string strPrice = Console.ReadLine();
        price = double.Parse(strPrice);

        Console.WriteLine("The product's price is: " + price.ToString());
    }

    public void ReadCount()
    {
        Console.WriteLine("Amount of the product?");
        string strCount = Console.ReadLine();
        count = int.Parse(strCount);

        Console.WriteLine("Amount of product: " + count.ToString());
    }

    public void CalculateTotalPrice()
    {
        double totalPrice = count * price;
        Console.WriteLine("Total price for " + count.ToString() + " units of " + name + " = " + totalPrice);
    }
}