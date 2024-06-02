using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class ClassA
    {
        public void f1()
        {
            Console.WriteLine("F1 function of class A");
        }
    }
    internal class ClassB:ClassA
    {
        public void f2()
        {
            Console.WriteLine("F2 function of class B");
        }
    }
    internal class ClassC : ClassA
    {
        public void f3()
        {
            Console.WriteLine("F3 function of class C");
        }
    }

    class Inheritance
    {
        static void Main(string[] args)
        {
            ClassB obj1 = new ClassB();
            obj1.f1();
            obj1.f2();
            ClassC obj2 = new ClassC();
            obj2.f1();
            obj2.f3();
            Console.Read();
        }
    }
}
