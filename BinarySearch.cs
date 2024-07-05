using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA
{
    public class BinarySearch
    {
        // this is asc to desc
        public static int BSearch(int[] arr, int target)
        {
            int start = 0;
            int end = arr.Length-1;
            while (start <= end)
            { 
            int mid = start+ (end - start)/2;
                if (arr[mid] == target) { return mid; }
                if (arr[mid] > target)
                {
                    end = mid - 1;
                }
                else if (arr[mid] < target)
                {
                    start = mid + 1;
                }
                else {
                    return mid;
                }
            }
            return -1;
        }

        // this is desc to asc
        public static int agnosticBS(int[] arr, int target)
        {
            int start = 0;
            int end = arr.Length - 1;
            bool isAsc = arr[start] < arr[end];
            while (start <= end) 
            { 
                int mid = start + (end - start)/2;
                if(arr[mid] == target) { return mid; }

                if (isAsc) {
                    if (arr[mid] > target)
                    {
                        end = mid - 1;
                    }
                    else if (arr[mid] < target)
                    {
                        start = mid + 1;
                    }
                    else
                    {
                        return mid;
                    }
                }
                else {
                    return mid;
                
                }
                
            }
            return -1;
        }

        public static int CeilingofaNumber(int[] arr, int target)
        {
            int start = 0;
            int end = arr.Length - 1;
            while (start <= end) { 
                int mid= start+ (end - start)/2;
                if(mid== target) { return mid; }
                if(arr[mid]> target) { end = mid - 1; }
                else if (arr[mid]< target) {start= mid+1; }
                else return mid;
            }
            return start;
        }

        public static int FloorofaNumber(int[] arr, int target)
        {
            int start = 0;
            int end = arr.Length - 1;
            while (start <= end)
            {
                int mid = start + (end - start) / 2;
                if (mid == target) { return mid; }
                if (arr[mid] > target) { end = mid - 1; }
                else if (arr[mid] < target) { start = mid + 1; }
                else return mid;
            }
            return end;
        }


    }

    public class BSCall
    { 
        public static void CallBS()
        {
            int[] arr = { 1, 2, 4, 5, 6 };
            int index = BinarySearch.BSearch(arr, 4);
            int[] arrBS = { -18, -12, -4, 0, 1, 2, 4, 5, 6 };
            index = BinarySearch.BSearch(arrBS, -12);
        }
    }
}
