using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA
{
    public class Pattern
    {
        //logic 1:  Run the outer loop should be no of rows
        //logic 2: identify for every  row how many columns are there and what .
        //Logic 3 : what do you need to print
        public static void Pattern1(int size)
        {
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
        public static void Pattern2(int size)
        {
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }


        }
        public static void Pattern3(int size)
        {
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j <= size-i-1; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
        }
        public static void Pattern4(int size)
        {
            for (int i = 0; i < size; i++)
            {
                for (int j = 1; j <= i+1; j++)
                {
                    Console.Write(j+" ");
                }
                Console.WriteLine();
            }
        }
        public static void Pattern5(int size)
        {
            for(int i = 0; i < size* 2; i++)
            {
                int c = i;
                if(i > size)
                {
                    int value = i - size;
                    c = size - value - 1;
                }
                // int c = i > size ? 2 * size - i : i;
                for (int j = 0; j < c; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
        }
        public static void Pattern6(int size)
        {
            for (int row = 0; row < size; row++)
            {
                for (int j = 0; j < size - row-1; j++)
                {
                    Console.Write(" ");
                }
                for (int k = 0; k <= row; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

        }
        public static void Pattern7(int size)
        {
            for (int row = 0; row < size; row++)
            {
                for (int j = 0; j < size - row - 1; j++)
                {
                    Console.Write(" ");
                }
                for (int k = 0; k < row*2 +1; k++)
                {
                    Console.Write("*");
                }
                for (int j = 0; j < size - row - 1; j++)
                {
                    Console.Write(" ");
                }
                Console.WriteLine();
            }
        }
        public static void Pattern8(int size)
        {
            for (int row = 0; row < size; row++)
            {
                for (int j = 0; j < row+1; j++)
                {
                    Console.Write(" ");
                }
                for (int k = 0; k < size * 2 -(2 *row)-1; k++)
                {
                    Console.Write("*");
                }
                for (int j = 0; j < row+1; j++)
                {
                    Console.Write(" ");
                }
                Console.WriteLine();
            }
        }
        public static void Pattern9(int size)
        {
            for (int i = 0; i < 2 * size; i++)
            {
                int totalColsInRow = i > size ? 2 * size - i : i;
                int space = size - totalColsInRow;
                for (int j = 0; j < space; j++)
                {
                    Console.Write(" ");
                }
                for (int k = 0; k < totalColsInRow; k++)
                {
                    Console.Write("* ");
                }

                //for (int l = 0; l < space; l++)
                //{
                //    Console.Write(" ");
                //}
                Console.WriteLine();

            }
        }
        public static void Pattern10(int size)
        {
            for (int i = 1; i <= size; i++)
            {
               // int totalColsInRow = i > size ? 2 * size - i : i;
                int space = size - i;
                for (int j = 0; j < space; j++)
                {
                    Console.Write(" ");
                }
                for (int k = i; k >= 1; k--) {
                    Console.Write(k);
                }
                for (int l = 2; l <= i; l++)
                {
                    Console.Write(l);
                }
                Console.WriteLine();
            }
         
        }


        public static void Main() 
        {
            Pattern1(4);
        }
    }
}
