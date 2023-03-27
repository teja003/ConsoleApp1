using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class ConstructorAndDestructor
    {
        public ConstructorAndDestructor() {
            Console.WriteLine("constructor called");
        }
        public void CallMe()
        {
            Console.WriteLine("From call me");
        }
        ~ConstructorAndDestructor() {
            Console.WriteLine("Destructor Called");
        }
    }
}
