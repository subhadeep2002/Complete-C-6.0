using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Exam5
    {
        static void Main(string[] args)
        {
            Distance d1 = new Distance(10, 20);
            d1.Addition();
            Console.Read();
        }
        class Distance 
        {
            int dist1, dist2, dist3;
            public Distance(int dist1, int dist2)
            {
                this.dist1 = dist1;
                this.dist2 = dist2;
            }
            public void Addition()
            {
                dist3 = dist1+dist2;
                Display();
            }
            public void Display() 
            {
                Console.WriteLine("Dis1 : " + dist1);
                Console.WriteLine("Dis2 : " + dist2);
                Console.WriteLine("Addition : " + dist3);
            }
        }
    }
}
