using ConsoleApp1.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class ClsGeneric1<G1,G2>
    {
        public void Display(G1 s1,G2 s2)
        {
            Console.WriteLine("value are:{0},{1}" ,s1,s2);
        }
    }
    class ClsGeneric2
    {
        static void Main(string[] args) 
        {
            ClsGeneric1<string,int> obj1 = new ClsGeneric1<string, int>();
            ClsGeneric1<int,float> obj2 = new ClsGeneric1<int, float>();
            ClsGeneric1<double,string> obj3 = new ClsGeneric1<double, string>();

            obj1.Display("durga",45);
            obj2.Display(20,67.8f);
            obj3.Display(34.56,"ram");

            Console.Read();
        }
    }
}
