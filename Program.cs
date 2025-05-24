using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountFunction
{
    class Program
    {
        static void Main()
        {
            List<object> items = new List<object>
        {
            "BMW", "Mercedes Benz", "Audi", +27, +67, 1, 0.55, 105,
            "BMW", "Mercedes Benz", "Audi", +27, 0.55, 105,
            "BMW", +27, +67, 1, 0.55, 105
        };

            CountItems(items);
        }

        static void CountItems(List<object> items)
        {
            Dictionary<object, int> counts = new Dictionary<object, int>();

            foreach (var item in items)
            {
                if (counts.ContainsKey(item))
                    counts[item]++;
                else
                    counts[item] = 1;
            }

            foreach (var pair in counts)
            {
                Console.WriteLine($"{pair.Key}: {pair.Value}");
            }
        }
    }
}
