using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Car
    {
        static void Main(string[] args)
        {
            int speed = 300;
            Vehicle v1= new Vehicle();
            v1.m1();
            Console.ReadLine();
        }
    }
    class Vehicle
    {
        int speed = 100;
        string name = "creta";

        public void m1() 
        {

            Console.WriteLine("Car name is :" + name);
            Console.Write("Car Speed is :"+speed);
        }
    }
}
