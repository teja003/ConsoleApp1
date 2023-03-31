using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving
{
    public class BaseCalculator
    {
        public int AddNums(int a, int b)
        {
            return a + b;
        }
        public int AddNums(int a, int b, int c)
        {
            return a + b + c;
        }
        public int SubNums(int a, int b)
        {
            return a - b;
        }
        public int SubNums(int a, int b, int c)
        {
            return a - b - c;
        }
    }
    public class NormalCalculator : BaseCalculator
    {

    }

    public class OppositeCalculator : BaseCalculator
    {
        public int AddNums(int a, int b)
        {
            return base.SubNums(a, b);
        }
        public int AddNums(int a, int b, int c)
        {
            return base.SubNums(a, b,c);
        }
        public int SubNums(int a, int b)
        {
            return base.AddNums(a, b);
        }
        public int SubNums(int a, int b, int c)
        {
            return base.AddNums(a, b,c);
        }
    }

    public class PolymorphismCalculator
    {
        public static void main(string[] args)
        {
            NormalCalculator n1 = new NormalCalculator();
            OppositeCalculator o1 = new OppositeCalculator();
            Console.WriteLine(n1.AddNums(5,4));
            Console.WriteLine(n1.SubNums(5, 4));
            Console.WriteLine(o1.AddNums(5, 4));
            Console.WriteLine(o1.SubNums(5, 4));
        }
    }
}
