using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA
{
    public class Recursion
    {
        static void print(int n)
        {
            if (n == 1) { Console.WriteLine(n); return; }

            Console.WriteLine(n);
             print(n-1);
        }
        static int factorial(int n)
        {
            if(n == 1) { Console.WriteLine(n); return 1; }
            return n * factorial(n - 1);
        }

        static int SumOfDigits(int n) 
        {
            if( n <= 1) { Console.WriteLine(n); return 1; }
            int result = n % 10;
            return result + SumOfDigits(n/10);
        }

        static int ProdOfDigits(int n)
        {
            if (n <= 1) { Console.WriteLine(n); return 1; }
            int result = n % 10;
            return result * ProdOfDigits(n / 10);
        }
        static int sum = 0;
        static int ReverseANumber(int number)
        {
            if(number <= 1) { Console.WriteLine(number); return 1; }
            int rem=number % 10;
            sum = sum * 10 + rem;
            sum = ReverseANumber(number / 10);
            return sum;
        }
        static int ReverseANumber2(int number)
        {
           if( number <= 1) { Console.WriteLine(number); return 1; }
            int digits = (int)Math.Log10(number);
            int rem = number % 10;
            return rem * (int)Math.Pow(10, digits) + ReverseANumber2(number / 10);
        }

        static bool Palindrome(int n) { 
        if(n <= 1) { Console.WriteLine(n); return true; }
            int value =ReverseANumber2(n);
            return n == value;
        }

        static int CountNoOfZeros(int n)
        { 
        if(n <= 1) { Console.WriteLine(n); return 0; }

            int remainder = n % 10;
            if(remainder == 0) { sum++; }
            CountNoOfZeros(n / 10);
            return sum;
        }

        static int NumberOfSteps(int n ,int steps =0) 
        {
            if(n==0) { Console.WriteLine(n); return steps; }    
            if (n % 2 == 0) {
                steps = steps + 1;
                NumberOfSteps(n / 2, steps);
            }
            else
            {
                steps = steps + 1;
                NumberOfSteps((n - 1) , steps);
            }
                
            return steps;
        }
        public static void Main() {
           var value = NumberOfSteps(14);
        }
    }
}
