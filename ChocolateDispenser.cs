using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class ChocolateMachine
    {
        public List<string> chocolates = new List<string>();
        public void addChocolates(string color, int count)
        {
            for(int i = 0; i < count; i++)
            {
                this.chocolates.Add(color);
            }
        }
        public List<string> removeChocolates(int count) {
            var removedChocolates = new List<string>();
            for (int i = 0; i < count; i++)
            {   
                removedChocolates.Add(this.chocolates[this.chocolates.Count - 1]);
                this.chocolates.RemoveAt(this.chocolates.Count-1);
            }
            return removedChocolates;
        }
        public List<string> dispenseChocolates(int count)
        {
            List<string> res = new List<string> ();
            for (int i = 0; i < count; i++)
            {
                res.Add(this.chocolates[0]);
                this.chocolates.RemoveAt(0);
            }
            return res;
        }
        public List<string> dispenseChocolatesOfColor(int count, string color)
        {
            List<string> res = new List<string>();
            for (int i = 0; i < count; i++)
            {
                if (this.chocolates[i]== color)
                {
                    res.Add(this.chocolates[i]);
                    // remove from this.chocolates
                }
            }
            return res;

        }
        public Dictionary<string,int> noOfChocolates()
        {
             var res = new Dictionary<string,int>();
            var chacoSet = this.chocolates.GroupBy(x => x);
            foreach (var item in chacoSet)
            {
                res.Add(item.Key, item.Count());
            }
            
            return res;
        }
        public void sortChocolateBasedOnCount()
        {
            var res = this.noOfChocolates();
            this.chocolates.Clear();
            foreach (var item in res)
            {
                for(int i = 0; i < item.Value; i++)
                {
                    this.chocolates.Add(item.Key);
                }
            }

        }
        public void changeChocolateColor(int count, string color, string finalColor)
        {
            for(int i = 0; i < this.chocolates.Count; i++)
            {
                if(this.chocolates[i]== color)
                {
                    this.chocolates[i] = finalColor;
                    count--;
                }
                if (count == 0)
                {
                    break;
                }
            }
        }
        public Dictionary<int,string> changeChocolateColorAllOfxCount(string color, string finalColor)
        {
            int count = 0;
            for (int i = 0; i < this.chocolates.Count; i++)
            {
                if (this.chocolates[i] == color)
                {
                    this.chocolates[i] = finalColor;
                    count++;
                }
            }
            var res = new Dictionary<int,string>();
            res.Add(count, finalColor);
            return res;
        }
    }
    internal class ChocolateDispenser
    {
        public static void Main(string[] args)
        {
            ChocolateMachine cm = new ChocolateMachine();
           cm.addChocolates("green", 1);
            cm.addChocolates("yellow", 2);
              cm.addChocolates("green", 3);
             var removedchocos = cm.removeChocolates(2);
             var dispensedChocos = cm.dispenseChocolates(2);
             var dispenseGreen = cm.dispenseChocolatesOfColor(2,"green");
             cm.sortChocolateBasedOnCount();
            var noOfChocos = cm.noOfChocolates();
             foreach (var item in noOfChocos)
             {
                 Console.WriteLine($"{item.Key}:{item.Value} ");
             }
            
        }
    }
}

//