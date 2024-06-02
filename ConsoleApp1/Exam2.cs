using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Exam2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Number : ");
            int num = int.Parse(Console.ReadLine());
            ////Fibonacci series
            //Console.Write("\n Fibonacci series :");
            //int curr = 0;
            //int pre = 1;
            //while(curr <= num)
            //{
            //    Console.WriteLine("\t"+curr);
            //    int next = curr + pre;
            //    pre = curr;
            //    curr = next;
            //}
            //Console.ReadLine();

            //patterns
            //Console.WriteLine("\n\nTriangle :");
            //for(int i = 0;i<num; i++)
            //{
            //    for(int j = num-i;j>0;j--)
            //    {
            //        Console.Write(" ");
            //    }
            //    for (int k = 0; k < (i * 2) - 1; k++)
            //    {
            //        Console.Write("*");   
            //    }
            //    Console.WriteLine();
            //}
            ////Diamond
            //Console.WriteLine("\nDiamond :");
            //for(int i =0;i<num;i++)
            //{
            //    for(int j = num-i;j>0;j--)
            //    {
            //        Console.Write(" ");
            //    }
            //    for(int k = 0;k<(i*2);k++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}
            //for(int i = num;i>0;i--)
            //{
            //    for(int j = num -i;j>0;j--)
            //    {
            //        Console.Write(" ");
            //    }
            //    for(int k =0;k<(i*2)-1;k++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            //Prime Number
            bool isPrime = true;
            for(int i = 2; i < num-1;i++)
            {
                if(num%i==0)
                {
                    isPrime= false;
                    break;
                }
            }
            if(isPrime == true) 
            {
                Console.WriteLine("\nNumber "+num+"is Prime");
            }
            else
            {
                Console.WriteLine("\nNumber " + num + "is Non Prime");
            }
            Console.ReadLine();
        }
    }
}
