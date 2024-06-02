using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class ClsDelegate1
    {
        public void add(int x,int y)
        {
            Console.WriteLine("sum is :" + (x + y));
        }
        public void Sub(int x, int y)
        {
            Console.WriteLine("sub is :" + (x - y));
        }
        public void Mul(int x, int y)
        {
            Console.WriteLine("Mul is :" + (x * y));
        }
        public void Div(int x, int y)
        {
            Console.WriteLine("Div is :" + (x / y));
        }
    }
    //creating a delegate
    public delegate void mcdelegate(int x, int y);
    class ClsDelegate2
    {
        static void Main(string[] args)
        {
            //instantiating a delegate
            ClsDelegate1 obj1 = new ClsDelegate1();
            mcdelegate objd = new mcdelegate(obj1.add);
            objd += obj1.Sub;
            objd += obj1.Mul;
            objd += obj1.Div;

            //invoking a delegate
            objd(20, 10);
            objd -= obj1.Mul;
            objd -= obj1.Div;
            objd(40, 20);
            Console.Read();
        }
    }
}
