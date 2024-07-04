using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA
{
    public class StringManipulations
    {
        public static void stringMemory()
        {
            //two reference variable have same value point to the memory in the heap and as the value is changed it will create new memory(object)
            string name = "riyaz";
            string name2 = "riyaz";

            if (name == name2)
            {
                Console.WriteLine("Maps to same Object");
            }
            // below code will create two objects

            string a = new String("Ahmed");
            string b = new String("Ahmed");

            if (a == b)
            {
                Console.WriteLine("Maps to sameobject");
            }
            else
            {
                Console.WriteLine("NOT Maps to sameobject");
            }
        }

        public static bool palindrome(string str)
        {
            int start = 0;
            int end = str.Length;
            while (start < end)
            {
                if (str[start] == str[end-1])
                {
                    start = start + 1;
                    end = end - 1;
                }
                else
                    return false;
            }
            return true;
            //for (int i = 0; i < str.Length / 2; i++)
            //{ 

            //}

        }
    }
}
