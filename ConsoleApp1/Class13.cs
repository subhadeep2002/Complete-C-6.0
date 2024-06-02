using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Class13
    {
        static void Main(string[] args)
        {
            List<int> li = new List<int>();
            li.Add(10);
            li.Add(20);
            li.Add(30);
            li.Add(40);
            li.Add(50);

            //li.Insert(2,90);
            li.RemoveAt(3);
            for (int i=0;i<li.Count;i++)
            {
                Console.Write(li[i] + " ");
            }
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
