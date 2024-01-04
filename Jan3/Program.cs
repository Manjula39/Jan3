using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jan3
{
    public class TestDelegate
    {
        public delegate double FirstDel(double x, double y);
    public delegate void SendDel(string s);
    public static void Msg(string s) { }
    public static double Adding(double n1, double n2) { return n1 + n2; }
    public static double Substract(double num1, double num2) { return num1 - num2; }
    static void Main(string[] args)
    {
        FirstDel obj; 
                    
        obj = Adding;
        double res = obj.Invoke(4.5, 5.5); Console.WriteLine("adding ()  {0}", res);
        obj = Substract;
        double ans = obj.Invoke(4.5, 5.5); Console.WriteLine("substract()  {0}", ans);
        SendDel ob = Msg;
    }
}
}