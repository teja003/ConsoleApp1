using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class OwnGeneric<T>
    {
        public OwnGeneric(T message)
        {
            Console.WriteLine(message);
        }
        
    }
    internal class GenericsAndCollections
    {
        public static void OwnGenericMethod<T>(T val)
        {
            Console.WriteLine(val);
        }
        public static void main(string[] args)
        {
            // List
            List<string> myList = new List<string>() { "Element1", "Element2" };
            myList.Add("Element3");
            myList.Add("Element3");
            myList.Add("Element7");
            myList.Add("Element4");
            myList.Add("Element5");
            myList.Add("Element6");
            myList.Remove("Element3");
            foreach (var item in myList)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();
            // HashSet
            HashSet<int> intSet = new HashSet<int>() { 1,2,3,4,5,6};
            intSet.Add(7);
            intSet.Add(1);
            intSet.Remove(5);
            foreach (var item in intSet)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();
            // SortedSet
            var intSortedSet = new SortedSet<int>() { 3,5,7,1,9,3 };
            var charSortedSet = new SortedSet<char>() { 'R', 'Y', 'A', 'U', 'M', 'V' ,'a','A'};
            foreach (var item in intSortedSet)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();
            foreach (var item in charSortedSet)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();
            var stack1 = new Stack<int>();
            stack1.Push(1);
            stack1.Push(2);
            stack1.Push(3);
            while (stack1.Count!=0)
            {
                Console.Write(stack1.Pop()+" ");
            }
            Console.WriteLine();

            var charQueue = new Queue<char>();
            charQueue.Enqueue('a');
            charQueue.Enqueue('b');
            charQueue.Enqueue('c');
            charQueue.Enqueue('d');
            while (charQueue.Count != 0)
            {
                Console.Write($"{charQueue.Dequeue()} ");
            }

            /*
             * Own generic class and methods
            OwnGeneric<int> generic1 = new OwnGeneric<int>(1);
            OwnGeneric<string> genericStr = new OwnGeneric<string>("Yuvateja Reddy");
            OwnGeneric<long> genericLong = new OwnGeneric<long>(500001L);
            OwnGenericMethod("Teja");
            OwnGenericMethod(1);
            */
        }

    }
}
