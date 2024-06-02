using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class TWODArray
    {
        static void Main(string[] args)
        {

            int[,] A = new int[3, 3] { { 10,20,30},{ 40,50,60},{ 70,80,90} };
            //A[0, 0] = 10;
            //A[0, 1] = 20;
            //A[0, 2] = 30;

            //A[1, 0] = 40;
            //A[1, 1] = 50;
            //A[1, 2] = 60;

            //A[2, 0] = 70;
            //A[2, 1] = 80;
            //A[2, 2] = 90;

            Console.WriteLine("Elements of Array are : ");

            for (int r = 0; r < 3; r++)
            {
                for (int c = 0; c < 3; c++)
                {
                    Console.Write(A[r, c] + " ");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
