


// See https://aka.ms/new-console-template for more information
using DSA;
Pattern.Pattern1(4);
Console.WriteLine("Hello, World!");
StringManipulations.palindrome("abcdcba");
StringManipulations.palindrome("abccba");
StringManipulations.palindrome("abccda");
BSCall.CallBS();
int[] arr = { 1, 2, 4, 5, 6 };
LinearSearch.LinearSearch1(arr, 5);
LinearSearch.SearchChar("Riyaz", 'z');
bool searchInRange = LinearSearch.SearchInRange(arr, 4, 1, 3);
Console.WriteLine(searchInRange);

int[] minArr = { 3, 56, 78, 35, -4 };
int minValue = LinearSearch.MinNumber(minArr);
Console.WriteLine(minValue);
bool existsIn2D = LinearSearch.SearchIn2D(15);
Console.WriteLine(existsIn2D);
bool existsInJaggedArray =LinearSearch.SearchInJagged2D(38);
Console.WriteLine(existsInJaggedArray);
int count = LinearSearch.FindCountOfEvenNumbersofDigits2(minArr);
Console.WriteLine(count);
public class LinearSearch
{
    public static int LinearSearch1(int[] arr, int target)
    {
        if (arr.Length == 0) { 
        return -1;
        }
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] == target)
            {
                return i;
            }
        }

       
        return -1;
    }

    public static bool SearchChar(string name, char target)
    {
        if (name.Count() == 0)
        {
            return false;
        }
        for (int i = 0; i < name.Count(); i++)
        {
            if (name[i] == target)
            {
                return true;
            }
        }


        return false;
    }

    public static bool SearchInRange(int[] arr, int target, int start, int end)
    {
        if (arr.Length == 0)
        {
            return false;
        }
        for (int i = start; i < end; i++)
        {
            if (arr[i] == target)
            {
                return true;
            }
        }
        return false;
    }

    public static int MinNumber(int[] arr)
    {
        if (arr.Length == 0)
        {
            return -1;
        }
        int min = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            if (min > arr[i]) { 
            min = arr[i];
            }
        }
        return min;

    }

    public static int MaxNumber(int[] arr)
    {
        if (arr.Length == 0)
        {
            return -1;
        }
        int max = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            if (max < arr[i])
            {
                max = arr[i];
            }
        }
        return max;

    } 

    public static bool SearchIn2D(int target)
    {
        int[,] array = {
                            { 1, 2, 3, 4 },
                            { 5, 6, 7, 8 },
                            { 9, 10, 11, 12}
                        };

        for(int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                if (array[i,j] == target)
                {
                    return true;
                }
            }
        }
        return false;

    }

    public static bool SearchInJagged2D(int target)
    {
        int[][] array = {
                           new int[] { 1, 2, 3, 4 },
                           new int[]{ 5, 6, 7, 8 },
                           new int[]{ 9, 10, 11, 12,15},
                           new int[]{ 30,35}
                        };

        for (int i = 0; i < array.Length; i++)
        {
            for (int j = 0; j < array[i].Length; j++)
            {
                if (array[i][j] == target)
                {
                    return true;
                }
            }
        }
        return false;

    }

    public static int FindCountOfEvenNumbersofDigits(int[] arr)
    {
        if (arr.Length == 0)
        {
            return -1;
        }
        int count = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            int intenalCount = 0;
            int n = arr[i];
            if (n < 0) { n = n * -1; }
            while (n > 0) {
                intenalCount++;
                n = n / 10;
            }
            if (intenalCount % 2 == 0)
            {
                count ++;
            }
        }
        return count;
    }
    public static int FindCountOfEvenNumbersofDigits2(int[] arr)
    {
        int count = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            int n = arr[i];
            if (n < 0) { n = n * -1; }
            int result = (int)Math.Log10(n) + 1;
            if (result % 2 == 0)
            {
                count++;
            }
        }
        return count;
    }

    public static int maximumWealth(int[][] accounts)
    {
        int max = 0;
        for (int i = 0; i < accounts.Length; i++)
        {
            int count = 0;
            for(int j = 0; j < accounts[i].Length; j++)
            {
                count = count +accounts[i][j];
            }
            if (count > max)
            {
                max = count;
            }
        }
        return max;
    }
}
