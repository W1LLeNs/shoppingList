using System;
using System.Collections.Generic;

class Product
{
    public string Name { get; }
    protected decimal BasePrice { get; }

    public virtual decimal Price => BasePrice;

    protected Product(string name, decimal basePrice)
    {
        Name = name;
        BasePrice = basePrice;
    }

    public override string ToString()
    {
        return $"Продукт: {Name}, ціна: {Price}грн;\n\n---\n";
    }
}

class Carrot : Product
{
    public Carrot(decimal basePrice) : base("морква", basePrice) { }
}

class Potato : Product
{
    private int Count { get; }
    public override decimal Price => BasePrice * Count;

    public Potato(decimal basePrice, int count) : base("картопля", basePrice)
    {
        Count = count;
    }

    public override string ToString()
    {
        return $"Продукт: {Name}; \nЦіна (за кг): {BasePrice}грн;  \nВага (в кілограмах): {Count}кг; \nЗагальна ціна: {Price}грн;\n\n---\n";
    }
}

class Cucumber : Product
{
    private int Count { get; }
    public override decimal Price => BasePrice * Count;

    public Cucumber(decimal basePrice, int count) : base("огірок", basePrice)
    {
        Count = count;
    }

    public override string ToString()
    {
        return $"Продукт: {Name}; \nЦіна (за кг): {BasePrice}грн;  \nВага (в кілограмах): {Count}кг; \nЗагальна ціна: {Price}грн;\n\n---\n";
    }
}

class VegetableShop
{
    private List<Product> products = new List<Product>();

    public void AddProducts(List<Product> newProducts)
    {
        products.AddRange(newProducts);
    }

    public void PrintProductsInfo()
    {
        decimal total = 0;
        foreach (var product in products)
        {
            Console.WriteLine(product);
            total += product.Price;
        }
        Console.WriteLine($"Загальна ціна усіх продуктів: {total}грн\n\n\n");
    }
}

class Program
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.InputEncoding = System.Text.Encoding.UTF8;

        var products = new List<Product>
        {
            new Carrot(15),
            new Potato(20, 4),
            new Cucumber(14, 2)
        };

        VegetableShop shop = new VegetableShop();
        shop.AddProducts(products);
        shop.PrintProductsInfo();
    }
}
