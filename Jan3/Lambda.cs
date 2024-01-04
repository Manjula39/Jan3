using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Jan3
{
    public class Lambda
    {
        public delegate double CalAreaPointer(double r);
        static void Main(string[] args)
        {
            CalAreaPointer cp = abc => 3.14 * abc * abc;
            double area = cp(3.5);
            Console.WriteLine("lambda expression   area " + area);
            Console.ReadLine();
        }
    }
}
