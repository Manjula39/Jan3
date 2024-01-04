using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jan3
{
    public class Anonymous
    { 
    public delegate double CalAreaPointer(double r);
        static void Main(string[] args)
        {
            CalAreaPointer cp = new CalAreaPointer(delegate (double x)
            { 
                return 3.14 * x * x;
            });
            double area = cp.Invoke(3.5); cp(3.5);
            Console.WriteLine(" anonymous methods to calculate area " + area);
            Console.ReadLine();
        }
    }
}