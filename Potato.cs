using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shoppingList
{
    public class Potato : Product
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
}
