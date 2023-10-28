using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binary_Search_Homework // don't edit this line!!!
{
    public class BinarySearchHomework // don't edit this line!!!
    {
        public static int TernarySearch(int[] arr, int key, int start, int end) // don't edit this line!!!
                                                                                // يمكنك تجاهل برمترات البداية والنهاية إذا لا تريد استخدام الطريقة العودية 
                                                                                // لكن لاتقوم بحذفهم أو التعديل عليهم هنا تحت اي ظرف!!!
                                                                                // من الممكن تمرير قيمة 0 لتجاهلهم
        {
            //TODO: write code for the ternary search algorithm and return the index of the element
            int mid1 = start + (end - start) / 3;
            int mid2 = end - (end - start) / 3;
            if (start > end)
            {
                return -1;
            }
            if (key == arr[mid1])
                return mid1;
            if (key == arr[mid2])
                return mid2;
            if (key < arr[mid1])
            {
                return TernarySearch(arr, key, start, mid1 - 1);
            }
            if (key > arr[mid2])
                return TernarySearch(arr, key, mid2 + 1, end);

            return TernarySearch(arr, key, mid1 + 1, mid2 - 1);

        }

        public static int BinarySearchForCalculatingRepeated
            (int[] arr, int key, bool is_first, int start, int end) // don't edit this line!!!
                                                                    // يمكنك تجاهل برمترات البداية والنهاية إذا لا تريد استخدام الطريقة العودية 
                                                                    // لكن لاتقوم بحذفهم أو التعديل عليهم هنا تحت اي ظرف!!!
                                                                    // من الممكن تمرير قيمة 0 لتجاهلهم
        {
            //TODO: this methods is for getting the first accurence of the key and the last accurance

            int mid = (start + end) / 2;
            if (is_first = true)
            {
                if (key == arr[mid])
                {
                    if (key == arr[mid - 1])
                    {
                        return BinarySearchForCalculatingRepeated(arr, key, true, start, mid - 1);
                    }
                    return mid;

                }
                if (key < arr[mid])
                {
                    return BinarySearchForCalculatingRepeated(arr, key, true, start, mid - 1);

                }
                if (key > arr[mid])
                {
                    return BinarySearchForCalculatingRepeated(arr, key, true, mid + 1, arr.Length - 1);
                    return BinarySearchForCalculatingRepeated(arr, key, true, mid + 1, end);

                }
            }
            
        
            if (key == arr[mid])
            {
                if (key == arr[mid + 1])
                {
                    return BinarySearchForCalculatingRepeated(arr, key, false,mid+1, end);
                }
                return mid;
            }
            if (key < arr[mid])
            {
                return BinarySearchForCalculatingRepeated(arr, key, false, start, mid - 1);

            }
            if (key > arr[mid])
            {
                return BinarySearchForCalculatingRepeated(arr, key, false, mid + 1, end);

            }
            return 0;

        }

        public static int GetRepeatCount(int[] arr, int key) // don't edit this line!!!
        {
            //TODO: write code to calculate the repeat count of a spacific element
            // make sure to use the previous method in this method
            Console.WriteLine("this is a first index:");
            int is_first = BinarySearchForCalculatingRepeated(arr, 5, true, 0, arr.Length - 1);
            Console.WriteLine("this is a last index:");
            int is_last = BinarySearchForCalculatingRepeated(arr, 5, false, 0, arr.Length - 1);
            int count = is_last - is_first + 1;
            Console.WriteLine("the calculate the repeat count :");
            return count;
        }
    }
}
