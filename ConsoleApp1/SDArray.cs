using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class SDArray
    {
        static void Main(string[] args)
        {
            //int[] A = new int[7] { 10, 20, 30, 40,50,60,70 };
            //A[0] = 10; 
            //A[1] = 20; 
            //A[2] = 30; 
            //A[3] = 40;

            //Console.Write(A[0] + " ");
            //Console.Write(A[1] + " ");
            //Console.Write(A[2] + " ");
            //Console.Write(A[3] +" ");
            string[] A = new string[4] { "sai", "raj", "ram", "mohan" };
            //for(int i = 0; i<A.Length; i++) 
            //{
            //    Console.Write(A[i] + " ");
            //}
            foreach(string s in A) 
            {
                Console.Write(s);
            }
            Console.WriteLine("Length is : " + A.Length);
            Console.WriteLine("Rank is : " + A.Rank);
            Console.Read();
        }
    }
}
