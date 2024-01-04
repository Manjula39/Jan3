using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jan3
{
    public class FirstDelAnLambda
    {
        public delegate double CalAreaPointer(double r);
        static double CalculateArea(double n)
        {
            return 3.14 * n * n;
        }
        static void Main(string[] args)
        {
            CalAreaPointer cp = CalculateArea;
            double area = cp.Invoke(3.5);
            Console.WriteLine("area calculated with delegate way " + area);
            Console.ReadLine();
        }
    }
}