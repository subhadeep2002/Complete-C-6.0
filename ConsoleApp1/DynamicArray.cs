using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class DynamicArray
    {
        static void Main(string[] args)
        {
            int[] A = new int[8] { 10, 20, 30, 40, 50, 60, 70, 80 };
            Console.WriteLine("Elements of Array are");
            foreach (int i in A)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine("\nEnter new size of the array");
            int N = int.Parse(Console.ReadLine());
            Array.Resize(ref A, N);
            Console.WriteLine("Elements of array after resize");
            foreach(int i in A)
            {
                Console.Write(i + " ");
            }
            Console.ReadLine();
        }
    }
}
