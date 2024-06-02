using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class vehicle
    {
        String Vehicle_type;
        public void display()
        {
            Vehicle_type = "Car";
            Console.WriteLine("Parent Class :" + Vehicle_type);
        }
    }
    class Car2: vehicle
    {
        String model_type;
        String company_Name;
        public void display()
        {
            base.display();
            model_type = "Thar";
            company_Name = "Mahindra";
            Console.WriteLine("Child Class : " + model_type);
            Console.WriteLine("Child Class : " + company_Name);
        }
    }
    class Exam10
    {
        static void Main(string[] args)
        {
            Car2 car = new Car2();
            car.display();
            Console.ReadLine();
        }
    }
}
