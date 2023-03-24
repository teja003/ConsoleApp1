using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    /*
     Write a program in C# Sharp to count a total number of duplicate elements in an array.
    Write a program in C# Sharp to merge two arrays of same size sorted in ascending order.
    * Write a program in C# Sharp to separate odd and even integers in separate arrays
     */
    
    internal class ProblemSolving
    {
        public static void main(string[] args)
        {
            var duplicateEementsArr = new List<int>() { 1,1,2,3,4,4,5,6,7,7,8,9};
            int dupCount = FindDuplicateCount(duplicateEementsArr);
            Console.WriteLine("The duplicate no.of elements in Array is "+dupCount);
            var listHalf1 = new List<int>() { 1,3,5,8};
            var listHalf2 = new List<int>() { 2, 4, 6, 7 };
            var list3 = new List<int>() { 1, 2, 3, 4, 5, 6, 7 };
            var mergedArray = MergeTwoArrays(listHalf1 , listHalf2);
            //Console.WriteLine(mergedArray);
            Console.WriteLine($"Merged Array is : [{String.Join(", ", mergedArray.ToArray())}]");
            SeparateOddAndEven(list3);
        }
        public static int FindDuplicateCount(List<int> list)
        {
            var duplicateCount = 0;
            foreach (var item in list.GroupBy(i=>i))
            {
                if(item.Count() > 1) duplicateCount++;
            }
            return duplicateCount;
        }
        public static List<int> MergeTwoArrays(List<int> arr1, List<int> arr2)
        {
            List<int> resArray = new List<int>();
            int arr1Length = arr1.Count;
            int arr2Length = arr2.Count;
            int i=0, j=0;
            while(arr1Length>0 && arr2Length>0)
            {
                if (arr1[i] < arr2[j])
                {
                    resArray.Add(arr1[i]);
                    i++;
                    arr1Length--;
                }
                if (arr1[i] > arr2[j])
                {
                    resArray.Add(arr2[j]);
                    j++;
                    arr2Length--;
                }
            }
            if(arr2.Count==j)
            {
                resArray.Add(arr1[i]);
            }
            if (arr1.Count == i)
            {
                resArray.Add(arr2[i]);
            }
            return resArray;

        }
        public static void SeparateOddAndEven(List<int> numList)
        {
            var oddList = new List<int>();
            var evenList = new List<int>();
            numList.ForEach(num =>
            {
                if (num % 2 == 0)
                {
                    evenList.Add(num);
                }
                else
                {
                    oddList.Add(num);
                }
            });
            Console.WriteLine($"Odd numbers Array is : [{String.Join(", ", oddList.ToArray())}]");
            Console.WriteLine($"Even numbers Array is : [{String.Join(", ", evenList.ToArray())}]");
        }
    }
}
