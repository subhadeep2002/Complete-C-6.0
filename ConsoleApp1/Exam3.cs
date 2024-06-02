using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Exam3
    {
        static void Main(string[] args)
        {
            int r1, c1, r2, c2;
            Console.WriteLine("Enter Number of Rows in Matrix 1:");
            r1= int.Parse(Console.ReadLine());
            Console.WriteLine("ENter Number of Columns in Matrix 2:");
            c1 = int.Parse(Console.ReadLine());
            Matrix m1 = new Matrix(r1,c1);
            m1.Addelements();
            Console.Write("Enter Number of Rows in Matrix 2 :");
            r2 = int.Parse(Console.ReadLine());
            Console.Write("Enter Number of Columns in Matrix 2 :");
            c2 = int.Parse(Console.ReadLine());
            Matrix m2 = new Matrix(r2,c2);
            m2.Addelements();

            Console.WriteLine("Matrix 1 :");
            m1.DisplayMatrix();
            Console.WriteLine("Matrix 2 :");
            m2.DisplayMatrix();
            m1.MatrixAddition(m2);
            Console.Read();
        }
        class Matrix
        {
            int rows, columns;
            int[,] matrix;
            public Matrix(int rows,int columns) 
            {
                this.rows = rows;
                this.columns = columns;
                matrix = new int[rows,columns];
            }
            public Matrix()
            {
                rows = 0;
                columns = 0;
                matrix = new int[rows,columns];
            }
            public void Addelements()
            {
                Console.WriteLine("Enter " + (rows * columns) + "Elements :");
                for(int i=0;i<rows;i++) 
                {
                    for(int j=0;j<columns;j++)
                    {
                        matrix[i,j] = int.Parse(Console.ReadLine());
                    }
                }
            }
            public void DisplayMatrix()
            {
                for(int i =0;i<rows;i++)
                {
                    for(int j = 0; j < columns; j++) 
                    {
                        Console.Write(matrix[i,j]+"\t");
                    }
                    Console.WriteLine();
                }
            }
            public void MatrixAddition(Matrix m)
            {
                if(rows == m.rows && columns == m.columns) 
                {
                    Matrix ans = new Matrix(rows, columns);
                    for(int i =0;i<rows;i++)
                    {
                        for(int j = 0;j<columns;j++) 
                        {
                            ans.matrix[i,j] = matrix[i,j]+m.matrix[i,j];
                        }
                    }
                    Console.WriteLine("\nMatrix Addition : ");
                    ans.DisplayMatrix();
                }
                else
                {
                    Console.WriteLine("\nAddition Not Possible");
                }
            }
        }
    }
}
