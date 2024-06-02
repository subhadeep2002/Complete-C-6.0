using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class ClsDelegate
    {
        static void display(string s)
        {
            Console.WriteLine("value is:"+s);
        }
        //creating a delegate
        delegate void mydelegate(string s);
        static void Main(string[] args)
        {
            //instanting a delegate
            mydelegate objd = new mydelegate(display);
            //invoking a delegate
            objd("durgasoft");
            Console.Read();
        }
    }
}
