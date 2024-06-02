using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Parent
    {
        public void property()
        {
            Console.WriteLine("Cash +Gold+Lands");
        }
        public void Car()
        {
            Console.WriteLine("Alto car");
        }
    }
    class Child:Parent
    {
        public new void Car()
        { 
            base.Car();
            Console.WriteLine("Benz Car"); 
        }
    }
    class ClsOverride
    {
        static void Main(string[] args)
        {
            Child obj1 = new Child();
            obj1.property();
            obj1.Car();
            Console.Read();
        }
    }
}
