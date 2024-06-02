using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class RectangleMethodOverloading
    {
        public int area(int length, int breadth)
        {
            return length * breadth;
        }
        public float area(float x1, float y1)
        {
            return x1 * y1;
        }
        public double area(double x2, double y2)
        {
            return x2 * y2;
        }
    }
    internal class Exam10_2
    {
        static void Main(string[] args)
        {
            RectangleMethodOverloading rectangle = new RectangleMethodOverloading();
            Console.WriteLine("Area of length and breadth = " + rectangle.area(5,6));
            Console.WriteLine("Area of x1 and y1 = " + rectangle.area(4.0f, 5.1F));
            Console.WriteLine("Area of x2 and y2 = " + rectangle.area(5.0, 6.0));
            Console.ReadKey();
        }
    }
}
