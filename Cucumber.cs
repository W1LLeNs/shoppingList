using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shoppingList
{
    public class Cucumber : Product
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
}
