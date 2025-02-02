using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shoppingList
{
    public class VegetableShop
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

}
