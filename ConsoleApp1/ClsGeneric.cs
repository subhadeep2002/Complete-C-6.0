using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Properties
{
    internal class ClsGeneric
    {
        //public void display<G> (G s)
        //{
        //    Console.WriteLine("value is: "+ s);
        //}
        static void display<G1,G2>(G1 s1, G2 s2)
        {
            Console.WriteLine("values are: " + s1+","+s2+"");
        }
        static void Main(string[] args) 
        {
            //ClsGeneric obj1= new ClsGeneric();
            display<int,string>(100,"sai");
            display<string,float>("durga",45.6f);
            display<double,int>(34.56,300);
            Console.Read();
        }
    }
}
