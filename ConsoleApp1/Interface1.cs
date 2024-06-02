using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    interface Interface1
    {
        void f1();
    }
    interface Interface2
    {
        //void f1();
        void f1();
        //void f2();
    }
    class C : Interface1, Interface2
    { 
        void Interface1.f1() 
        {
            //Console.WriteLine("F1 function of interface1 and interface2");
            Console.WriteLine("F1 function of interface1");
        }
        void Interface2.f1()
        {
            //Console.WriteLine("F1 function of interface1 and interface2");
            Console.WriteLine("F1 function of interface1");
        }
        //public void f2() 
        //{
        //    Console.WriteLine("F2 function of interface2");
        //}
    }
    class ClsMultiple
    {
        static void Main(string[] args)
        {
            C obj1 = new C();
            //explicit interface implementation
            //Interface1 obj2 = obj1;
            //Interface2 obj3 = obj1;
            Interface1 obj2 = (Interface1)obj1;
            Interface1 obj3 = (Interface1)obj1;
            obj2.f1();
            obj3.f1();

            //obj1.f1();
            //obj1.f2();
            Console.Read();
        }
    }
}
