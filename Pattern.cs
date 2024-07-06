using System;
using System.Collections.Generic;
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

        public static void Main() 
        {
            Pattern1(4);
        }
    }
}
