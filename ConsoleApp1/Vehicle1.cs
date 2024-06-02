using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal interface Vehicle1
    {   
        void wheels();
        void color();

    }
    class Car1:Vehicle1
    {
        
        public void wheels()
        {
            Console.WriteLine("Car : 4 wheels");
        }

        public void color()
        {
            Console.WriteLine("Car : color is red");
        }
    }
    class Bike:Vehicle1
    {
        public void wheels()
        {
            Console.WriteLine("Bike : 2 wheels");
        }
        public void color()
        {
            Console.WriteLine("bike : color is black");
        }
    }
    class ClsAbstract
    {
        static void Main(string[] args)
        {
            Car1 obj1 = new Car1();
            obj1.wheels();
            obj1.color();
            Bike obj2 = new Bike();
            obj2.wheels();
            obj2.color();
            Console.Read();
        }
    }
}
