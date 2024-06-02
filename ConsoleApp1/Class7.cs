using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Class7
    {
        public int Add(int a, int b)
        {
            //Console.WriteLine("sum is : " + (a + b));
            return a + b;
        }
        public float Add(float a, int b)
        {
            //Console.WriteLine("sum is : " + (a + b));
            return a + b;
        }
        public int Add(int a, int b,int c)
        {
            //Console.WriteLine("sum is : " + (a + b + c));
            return a + b+c;
        }
        //static void Main(string[] args)
        //{
        //    Class7 obj1 = new Class7();
        //    obj1.Add(1, 2);
        //    obj1.Add(10.5f, 2);
        //    obj1.Add(1, 2,3);
        //    Console.Read();
        //}
    }
    class Class8
    {
        static void Main(string[] args)
        {
            Class7 obj1 = new Class7();
            Console.WriteLine("sum is :"+obj1.Add(1, 2));
            Console.WriteLine("sum is :" + obj1.Add(10.5f, 2));
            Console.WriteLine("sum is :" + obj1.Add(1, 2, 3));
            Console.Read();

        }
    }
}
