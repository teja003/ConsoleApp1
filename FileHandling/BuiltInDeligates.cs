using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileHandling
{
    delegate void delegateSayHello();
    internal class BuiltInDeligates
    {
        public static void main(string[] args)
        {
            delegateSayHello dSayHello = sayHello;
            dSayHello.Invoke();

            Action<string> actionSayHello = (msg) => Console.WriteLine(msg);
            actionSayHello("Cool");

            Func<int, int,int> funcAddTwo = (a,b) => a+b;
            Console.WriteLine(funcAddTwo(8,4));

            Predicate<int> predicateForTen = (a) =>  a>=10;
            Console.WriteLine(predicateForTen(9));
            // ! Action doesn't return any value
            // ! Func returns value, the typeof(return value)===typeof(last passed parameter)
            // ! Predicate return only boolean value & it takes only one parameter
            List<int> list = new List<int>() { 1,2,3,4,5,6,7,8};
            Predicate<int> check = (a) => a > 5;
            Console.WriteLine(list.All(a=>check(a)));
        }
            public static void sayHello()
        {
            Console.WriteLine("Hello");
        }
    }
    
}
