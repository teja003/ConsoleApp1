using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class CustomException : Exception
    {
        public CustomException(string msg) : base(msg)
        {

        }
    }
    internal class ExceptionHandling
    {
        public static void main(string[] args)
        {
            try
            {
                CheckCondition();

            }catch(CustomException e)
            {
                Console.WriteLine(e.Message);
            }

        }
        public static void CheckCondition()
        {
            if (10 < 11)
            {
                throw new CustomException("Invalid Operation");
            }
        }
    }
}
