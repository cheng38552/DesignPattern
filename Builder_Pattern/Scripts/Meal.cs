using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder_Pattern
{
    /// <summary>
    /// 餐點
    /// </summary>
    public class Meal
    {
        private List<Item> items = new List<Item>();

        public void AddItem(Item item)
        {
            items.Add(item);
        }

        public float getCost()
        {
            var cost = 0f;
            foreach (var item in items)
            {
                cost += item.price();
            }
            return cost;
        }

        public void ShowItems()
        {
            foreach (var item in items)
            {
                Console.WriteLine($"Item : {item.Name()}" +
                                $", Packing : {item.packing().pack()}" +
                                $", Price : {item.price()}");
            }
        }
    }
}
