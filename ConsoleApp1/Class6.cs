using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Class6
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Enter three numbers");
            //int a, b, c;
            //a=int.Parse(Console.ReadLine());
            //b=int.Parse(Console.ReadLine());
            //c=int.Parse(Console.ReadLine());
            //if (a>b && a>c)
            //{
            //    Console.WriteLine(a+" "+"Is Big");
            //}
            //else if(b>c)
            //{
            //    Console.WriteLine(b+" "+"Is Big");
            //}
            //else { 
            //    Console.Write(c+" "+"Is Big");
            //}

            //for(int i=1;i<=3;i++) 
            //{
            //    Console.WriteLine(i);
            //    for(int j = 100;j<=103;j++)
            //    { 
            //        Console.WriteLine(j);
            //    }
            //}

            //printing sum of first n numbers
            Console.WriteLine("Enter a number : ");
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            for(int i=0;i<=n;i++)
            {
                sum=sum+i;
            }
            Console.WriteLine("The first"+" "+n+" "+"numbers is:"+sum);
                
            Console.Read();
        }
    }
}
