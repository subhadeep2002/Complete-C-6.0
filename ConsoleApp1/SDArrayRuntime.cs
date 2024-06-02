using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class SDArrayRuntime
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter length of the array : ");
            int n = int.Parse(Console.ReadLine());
            int[] A = new int[n];
            Console.WriteLine("Enter" + " " + n + " " + "Values");
            for(int i =0;i<n;i++)
            {
                A[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Elements of Array are : ");
            for(int i = 0;i<n;i++) 
            {
                Console.Write(A[i] +" ");
            }
            Console.Read();
        }
    }
}
