using System;
using System.Collections;
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

        static bool isArraySorted(int[] arr,int start =0 ,int end =1)
        {
            if(start>arr.Length- 1 || end >arr.Length -1) { return true; }
            bool value = arr[start] < arr[end] && isArraySorted(arr, end, end + 1);
            if (!value) return false;
            else
                return true;

        }


        static bool LinearSearch(int[] arr, int target , int index = 0)
        {
            if(index> arr.Length - 1) { return false; }
            return arr[index] == target || LinearSearch(arr,target,index++);
        }

        static List<int> LinearSearch1(int[] arr, int target,  List<int> sol, int index = 0)
        {
            if (index > arr.Length - 1) { return sol; }
            if (arr[index] == target)
                sol.Add(index);
            index = index + 1;
            LinearSearch1(arr, target,sol, index);
            return sol;
        }

        static List<int> LinearSearch2(int[] arr, int target, int index = 0)
        {
            List<int> sol = new List<int>();
            if (index > arr.Length - 1) { return sol;  }
           
            if (arr[index] == target)
                sol.Add(index);
            index = index + 1;
            sol.AddRange(LinearSearch2(arr, target, index));
            return sol;
        }

        static void RotatedBinarySearch() { }

        static void PatternViaRecurrence(int r,int c)
        {
            if(r == 0) { return; }

            if (r > c)
            {
                Console.Write("*");
                PatternViaRecurrence(r, c + 1);
            }
            else
            {
                Console.WriteLine();
                PatternViaRecurrence(r - 1, 0);
            }
        }
        static void NormalTraingle(int r, int c)
        {
            if (r == 0) { return; }

            if (r > c)
            {
                NormalTraingle(r, c + 1);
                Console.Write("*");
                
            }
            else
            {
                NormalTraingle(r - 1, 0);
                Console.WriteLine();
                
            }
        }
        public static void Main() {
            NormalTraingle(4, 0);
            int[] arr = { 1, 2, 4, 4,4,5,7, 6 };
            var value = LinearSearch2(arr,4,0);
        }
    }
}
