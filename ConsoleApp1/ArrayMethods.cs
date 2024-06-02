using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class ArrayMethods
    {
        static void Main(string[] args)
        {
            int[] A = new int[7] { 10, 20, 30, 40, 50, 60, 70 };
            int[] B = new int[10] { 15, 5, 35, 25, 55, 45, 75, 65, 95, 85 };

            Console.WriteLine("Elements of array A are");
            foreach (int i in A)
            { Console.Write(i+" "); }
            Console.WriteLine("\nElements of array B are");
            foreach (int i in B)
            { Console.Write(i + " "); }
            //A.CopyTo(B, 2);
            //Array.Copy(A, B, 3);
            //Array.Copy(A, 3, B, 3, 4);
            //Array.Sort(B);
            //Array.Sort(B,2,4);
            //Console.WriteLine("\nElements of array B after copying are");
            //Console.WriteLine("\nElements of array B after sorting are");
            //Array.Reverse(A);
            //Array.Reverse(A,2,4);
            Array.Clear(A,2,4);
            Console.WriteLine("\nElements of array A after Clear are");
            foreach (int i in A)
            { Console.Write(i + " "); }
            Console.Read();
        }
    }
}
