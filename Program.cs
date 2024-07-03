


// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
int[] arr = { 1, 2, 4, 5, 6 };
Search.LinearSearch(arr, 5);
Search.SearchChar("Riyaz", 'z');
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
}
