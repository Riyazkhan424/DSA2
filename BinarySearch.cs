using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection.Metadata;
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
            int end = arr.Length - 1;
            while (start <= end)
            {
                int mid = start + (end - start) / 2;
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
                int mid = start + (end - start) / 2;
                if (arr[mid] == target) { return mid; }

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
                int mid = start + (end - start) / 2;
                if (mid == target) { return mid; }
                if (arr[mid] > target) { end = mid - 1; }
                else if (arr[mid] < target) { start = mid + 1; }
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

        public static char NextGreatestLetter(char[] arr, int target)
        {
            int start = 0;
            int end = arr.Length - 1;
            while (start <= end)
            {
                int mid = start + (end - start) / 2;
                char c = arr[mid];
                if (c > target)
                {
                    end = mid - 1;
                }
                else if (c < target)
                {
                    start = mid + 1;
                }
            }
            return arr[start % arr.Length];
        }

        public static int[] SearchRange(int[] arr, int taget)
        {
            int[] anw = { -1, -1 };
            int start = BinSearch(arr, taget, true);
            int end = BinSearch(arr, taget, false);
            anw[0] = start;
            anw[1] = end;
            return anw;
        }

        public static int BinSearch(int[] arr, int target, bool isStart)
        {
            int ans = -1;
            int start = 0;
            int end = arr.Length - 1;
            while (start <= end)
            {
                int mid = start + (end - start) / 2;
                if (arr[mid] > target)
                {
                    end = mid - 1;
                }
                else if (arr[mid] < target)
                {
                    start = mid + 1;
                }
                else if (start == end) {
                    ans = start;
                    return ans;
                }
                else
                {
                    ans = mid;
                    if (isStart)
                    {
                        end = mid - 1;
                    }
                    else
                    {
                        start = mid + 1;
                    }

                }
            }
            return ans;
        }

        public static int BinSearchInInfity(int[] arr, int target) 
        {
            int start = 0;
            int end = 1;
            if (arr[0] == target) return start;


            while (target > arr[end]) {
                start = end + 1;
                end = end * (2 * end);
            }
            return BSearchWithSE(arr, target, start, end);

        }

        public static int BSearchWithSE(int[] arr, int target,int start,int end)
        {
            while (start <= end)
            {
                int mid = start + (end - start) / 2;
                if (arr[mid] == target) { return mid; }
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
            return -1;
        }

        public static int PeakIndex(int[] arr)
        {
            //int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //int[] arr = { 10, 20, 15, 2, 23, 90, 67 };
            int a = -1;
            int start = 0;
            int end = arr.Length - 1;
            while (start < end)
            { 
                int mid = start+ (end - start) / 2;

                if (arr[mid] < arr[mid + 1])
                {
                    start = mid + 1;
                }
                else if (arr[mid] > arr[mid + 1])
                {
                  end = mid;
                 }
                else { return mid; }
            }
            return start;
        }

        public static int FindInMoutainArray(int target)
        {
            int[] arr = { 10, 20, 90, 15, 2, 23, 90, 67 };
            int peakIndex = PeakIndex(arr);
            var valie = BSearchWithSE(arr, target, 0, peakIndex);
            if (valie < 0)
            {
                return BSearchWithSE(arr, target, valie+1, arr.Length);
            }
            return valie;
        }
    }

    public class BSCall
    {
        public static void CallBS()
        {
            int[] arr = { 1, 2, 4,4,4,4,5, 5, 6 };
            var result = BinarySearch.SearchRange(arr, 4);
            int[] infiniteArray = new int[1000000];
            for (int i = 0; i < infiniteArray.Length; i++)
            {
                infiniteArray[i] = i * 2; // Example: even numbers
            }

            int target = 420;
            var resulr = BinarySearch.BinSearchInInfity(infiniteArray, target);
            resulr = BinarySearch.FindInMoutainArray(90);
            //PeakIndex
          var resu = BinarySearch.PeakIndex(arr);
            //int index = BinarySearch.BSearch(arr, 4);
            //int[] arrBS = { -18, -12, -4, 0, 1, 2, 4, 5, 6 };
            //index = BinarySearch.BSearch(arrBS, -12);
        }
    }
}
