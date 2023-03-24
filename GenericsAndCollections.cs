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
            Console.WriteLine();
            // Linked List
            var ll = new LinkedList<int>();
            ll.AddLast(1);
            ll.AddLast(2);
            ll.AddLast(3);
            ll.AddLast(4);
            ll.AddLast(5);
            ll.AddLast(2);
            ll.AddLast(8);
            ll.AddFirst(0);
            LinkedListNode<int> node5 = ll.Find(5);
            LinkedListNode<int> node8 = ll.Find(8);
            ll.AddBefore(node8,7);
            ll.AddAfter(node5, 6);
            LinkedListNode<int> head = ll.First;
            while (head.Next != null)
            {
                if (head.Value == 2)
                {
                    ll.AddBefore(head, 10);
                }
                head = head.Next;

            }
            foreach (var item in ll)
            {
                Console.Write($"{item} -> ");
            }
            Console.WriteLine("NULL");
            // Dictionary
            Dictionary<int, string> dict = new Dictionary<int, string>();
            dict.Add(1, "Yuva");
            dict.Add(2, "Cool");
            dict.Add(3, "Good");
            string nameInDict = dict[1];
            Console.WriteLine(nameInDict);
            foreach (var item in dict)
            {
                if (item.Value == "Cool")
                {
                    dict[item.Key] = "Cool!!";
                }
            }
            foreach (var item in dict)
            {
                Console.WriteLine($"{item.Key} : {item.Value}");
            }
            Console.WriteLine();
            //SortedDictionary
            SortedDictionary<string, string> sortDict = new SortedDictionary<string, string>();
            sortDict.Add("fname", "Yuvateja");
            sortDict.Add("lname", "Reddy");
            sortDict.Add("age", "21");
            sortDict.Add("email", "yuvateja@gmail.com");
            sortDict.Remove("age");
            foreach (var item in sortDict)
            {
                Console.WriteLine($"{item.Key} : {item.Value}");
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
