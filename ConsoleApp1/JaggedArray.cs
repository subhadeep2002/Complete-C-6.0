using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class JaggedArray
    {
        static void Main(string[] args)
        {
            int[][] A = new int[3][];
            A[0] = new int[3] { 10, 20, 30 };
            A[1] = new int[2] { 10, 20};
            A[2] = new int[4] { 10, 20, 30 ,40};

            Console.WriteLine("Elements of jagged array");
            for(int r=0;r<A.Length;r++)
            {
                for(int c = 0; c < A[r].Length;c++)
                {
                    Console.Write(A[r][c] + " ");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
