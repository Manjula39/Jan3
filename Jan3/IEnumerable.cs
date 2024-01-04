using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jan3
{
    public class IEnumerable
    {
        static void Main(string[] args)
        {
            List<int> years = new List<int>();
            //IList<int> years = new List<int>();
            years.Add(1990);
            years.Add(2000);
            years.Add(2001);
            IEnumerable<int> ienu = years;
            IEnumerable obj; 
            foreach (var x in years) { Console.WriteLine(x); }
            IEnumerator<int> emrate = years.GetEnumerator();
            while (emrate.MoveNext()) { Console.WriteLine(emrate.Current); }
            List<Product> p = new List<Product>()
            {
                new Product(){ID=11 },
                new Product(){ID=12 },
            };
        }
    }
    public class Product { public int ID { get; set; } }

}
