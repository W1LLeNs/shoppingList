using shoppingList;
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.InputEncoding = System.Text.Encoding.UTF8;

        var products = new List<Product>
        {
            new Carrot(20),
            new Potato(25, 4),
            new Cucumber(17, 3)
        };

        VegetableShop shop = new VegetableShop();
        shop.AddProducts(products);
        shop.PrintProductsInfo();
    }
}
