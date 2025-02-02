using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shoppingList
{
    public class Product
    {
        public string Name { get; }
        protected decimal BasePrice { get; }

        public virtual decimal Price => BasePrice;

        public Product(string name, decimal basePrice)
        {
            Name = name;
            BasePrice = basePrice;
        }

        public override string ToString()
        {
            return $"Продукт: {Name}, ціна: {Price}грн;\n\n---\n";
        }
    }
}
