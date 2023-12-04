using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment2
{
    //public class GenericSortUtility<T> where T : IComparable<T>
    //{
    //    // Sort in ascending order
    //    public static void AscendingSort(List<T> list)
    //    {
    //        if (list == null || list.Count <= 1)
    //            return;

    //        // Using a simple Bubble Sort algorithm for demonstration
    //        for (int i = 0; i < list.Count - 1; i++)
    //        {
    //            for (int j = 0; j < list.Count - 1 - i; j++)
    //            {
    //                if (list[j].CompareTo(list[j + 1]) > 0)
    //                {
    //                    // Swap elements
    //                    T temp = list[j];
    //                    list[j] = list[j + 1];
    //                    list[j + 1] = temp;
    //                }
    //            }
    //        }
    //    }
    //    private static void BubbleSortOfInt(int[] numbers)
    //    {
    //        int temp;
    //        for (int j = 0; j < numbers.Length - 1; j++)
    //        {
    //            for (int i = 0; i < numbers.Length - 1; i++)
    //            {
    //                if (numbers[i] > numbers[i + 1])
    //                {   //swap the numbers
    //                    temp = numbers[i + 1];
    //                    numbers[i + 1] = numbers[i];
    //                    numbers[i] = temp;
    //                }
    //            }
    //        }
    //    }
    //    // Sort in descending order
    //    public static void DescendingSort(List<T> list)
    //    {
    //        if (list == null || list.Count <= 1)
    //            return;

    //        // Using a simple Bubble Sort algorithm for demonstration
    //        for (int i = 0; i < list.Count - 1; i++)
    //        {
    //            for (int j = 0; j < list.Count - 1 - i; j++)
    //            {
    //                if (list[j].CompareTo(list[j + 1]) < 0)
    //                {
    //                    // Swap elements
    //                    T temp = list[j];
    //                    list[j] = list[j + 1];
    //                    list[j + 1] = temp;
    //                }
    //            }
    //        }
    //    }
    
}
