using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileHandling
{
    public class AsyncProgram2
    {
        public static async Task Fun1()
        {
            Console.WriteLine("F1 started");
            await Task.Delay(4000);
            Console.WriteLine("F1 Ended");
        }
        public static async Task Fun2()
        {
            Console.WriteLine("F2 started");
            await Task.Delay(4000);
            Console.WriteLine("F2 Ended");
        }
        public static async Task Main(string[] args)
        {
            await Fun1();
            await Fun2();
            //Task.WaitAll(Fun1(),Fun2());
            Console.ReadLine();
        }
    }
    internal class AsyncProgram
    {
        public static async Task main(string[] args)
        {
            /*Task<int> val =  ReturnTen();
            await val;*/
            var watch = new System.Diagnostics.Stopwatch();
            watch.Start();
            int val = await ReturnTen();
            Method1();
            Method2();
            //Console.WriteLine(val.Result);
            Console.WriteLine(val);
            Console.WriteLine(await ReturnTen());
            watch.Stop();
            Console.WriteLine(watch.ElapsedMilliseconds);
            Console.ReadLine();

        }
        public static async void Method1()
        {
            Console.WriteLine("Method1 Started");
            await Task.Delay(5000);                       
            Console.WriteLine("Method1 Ended");
        }
        public static async void Method2()
        {
            Console.WriteLine("Method2 Started");
            await Task.Delay(6000);
            Console.WriteLine("Method2 Ended");
        }
        public static async Task<int> ReturnTen()
        {
            await Task.Delay(5000);
            return 10;
        }
    }
}
