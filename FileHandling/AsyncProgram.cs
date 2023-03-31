using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileHandling
{
    
    public class AsyncFileHandling
    {
        public static async Task Main(string[] args)
        {
            await FileRead();
            await FileWrite("Initial Write");
            await FileRead();
            await FileWrite("data to write into file");
            await FileRead();
        }
        public static async Task FileRead()
        {
            string data = null;
            await Task.Run(async () =>
            {
                FileStream fs = new FileStream("C:\\Users\\HP\\Desktop\\internship\\C#\\FileHandling\\file.txt", FileMode.Open, FileAccess.Read);
                StreamReader sr = new StreamReader(fs);
                data = await sr.ReadLineAsync();
                sr.Close();
                fs.Close();
            });
            Console.WriteLine(data);
        }
        public static async Task FileWrite(string msg)
        {
            await Task.Run(() =>
            {
                FileStream fs = new FileStream("C:\\Users\\HP\\Desktop\\internship\\C#\\FileHandling\\file.txt", FileMode.OpenOrCreate, FileAccess.Write);
                StreamWriter sr = new StreamWriter(fs);
                sr.WriteAsync(msg);
                sr.Close();
                fs.Close();
            });

        }
    }
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
        public static async Task main(string[] args)
        {
        /*    await Fun1();
            await Fun2();*/
            Task.WaitAll(Fun1(),Fun2()); /*WhenAll, WhenAny, WaitAll, WaitAny*/
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



