using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class TwoDArrayRuntime
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number of rows : ");
            int r = int.Parse(Console.ReadLine());
            Console.WriteLine("Eneter number of columns : ");
            int c = int.Parse(Console.ReadLine());

            int[,] A = new int[r, c];
            Console.WriteLine("Enter" + " " + r * c + " " + "values");

            for(int i = 0; i < r; i++)
            {
                for(int j=0;j<c;j++)
                {
                    A[i,j] = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine("Elements of Array are");
            for(int i =0;i < r; i++)
            {
                for(int j =0;j<c;j++)
                {
                    Console.Write(A[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.Read();
        }
    }
}
