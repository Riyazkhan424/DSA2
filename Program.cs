


// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
int[] arr = { 1, 2, 4, 5, 6 };
Search.LinearSearch(arr, 5);
Search.SearchChar("Riyaz", 'z');
bool searchInRange = Search.SearchInRange(arr, 4, 1, 3);
Console.WriteLine(searchInRange);

int[] minArr = { 3, 56, 78, 35, -4 };
int minValue = Search.MinNumber(minArr);
Console.WriteLine(minValue);

public class Search
{
    public static int LinearSearch(int[] arr, int target)
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

}
