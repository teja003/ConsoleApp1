using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving
{
    abstract public class NumberPredictor
    {
        public int DateOfBirth;
       public NumberPredictor(int DateOfBirth)
        {
            this.DateOfBirth = DateOfBirth;
        }
        public int Fibonacci(int n)
        {
            if(n <= 1) return 1;
            else
            {
                return Fibonacci(n-1)+Fibonacci(n-2);
            }
        }
        public int GetLuckyNumber()
        {
            // 1 1 2 3 5 8 13 21 34
            List<int> luckyNumberList = new List<int>();
            for(int i = 1; i < 10; i++)
            {
                luckyNumberList.Add(this.Fibonacci(i));
            }
            int luckyNumber = luckyNumberList[0];
            for (int i = 0; i<luckyNumberList.Count-1; i++)
            {
                if (Math.Abs(this.DateOfBirth - luckyNumberList[i]) < Math.Abs(luckyNumberList[i + 1] - this.DateOfBirth))
                {
                    luckyNumber = luckyNumberList[i];
                    break;

                }
            }
            return luckyNumber;

        }
        public abstract int GetUnLuckyNumber();
    }
    public class LuckyNumberPredictor : NumberPredictor
    {
        public LuckyNumberPredictor(int dateOfBirth):base(dateOfBirth)
        {
            
        }

        public override int GetUnLuckyNumber()
        {
            int unLuckyNumber = 0;
            base.DateOfBirth.ToString().ToList().ForEach(x => unLuckyNumber += int.Parse(x.ToString()));
            return unLuckyNumber;
        }
    }
    public class Predictor
    {
        public static void main(string[] args)
        {
            NumberPredictor n1 = new LuckyNumberPredictor(29);
            n1.GetLuckyNumber();
            n1.GetUnLuckyNumber();
        }
    }
}
