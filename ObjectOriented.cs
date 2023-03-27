using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Test
    {
        public void TestDisplay()
        {
            Test1 test1Obj = new Test1();
        }
        public class Test1
        {
            public void PublicDisplay(string s)
            {
                Console.WriteLine(s);
            }
            protected void ProtectedDisplay(string s)
            {
                Console.WriteLine(s);
            }
            private void PrivateDisplay(string s)
            {
                Console.WriteLine(s);
            }
        }
    }

    public class FourWheeler
    {
        public virtual void Test()
        {
            Console.WriteLine("Four Wheeler");
        }
    }
    public class Car : FourWheeler
    {
        public void StartCar()
        {
            Console.WriteLine("Car Started");
        }
        public void StopCar()
        {
            Console.WriteLine("Car Stopped");
        }
        public override void Test()
        {
            Console.WriteLine("Inside Car");
        }

    }
    // ! C# allows multi-level inheritance
    public class SportsCar : Car
    {
        public override void Test()
        {
            Console.WriteLine("Inside SportsCar");
        }
    }
    public class Stud
    {
        public string name;
        public int age;
        public string dept;
        public Marks marks;
        public Stud(string name, int age, string dept, Marks marks)
        {
            this.name = name;
            this.age = age;
            this.dept = dept;
            this.marks = marks;
        }
        public void DisplayStudent()
        {
            marks.CalculatePercentage();
            Console.WriteLine($"{this.name}'s percentage is {this.marks.percentage}");
        }
    }

    public class Marks
    {
        public int totalMarks;
        public int totalSubjects;
        public float percentage;
        public Marks(int totalMarks, int totalSubjects)
        {
            this.totalMarks = totalMarks;
            this.totalSubjects = totalSubjects;
        }
        public void CalculatePercentage()
        {
            this.percentage = this.totalMarks/this.totalSubjects;
        }
    }

    // if method is abstract method then class also should be abstract class & abstract method should not have any body;
    // abstract class can have both abstract and non-abstract method
    // abstract class should go inherit & also should implement the body for abstract method inside the child class
    abstract public class AEmployee
    {
        public void Display()
        {
            Console.WriteLine("From Display");
        }
        abstract public void Calculate();
    }
    public class EmployeeA : AEmployee {
        public override void Calculate()
        {
            Console.WriteLine("calculate");
        }
    }

    // Interface
    public interface IEmployee
    {
        public void DisplayName();
        public void DisplayRole();
        public void DisplayDetails();
    }

    public class Employee : IEmployee
    {
        public void DisplayName()
        {
            Console.WriteLine("From DisplayName");
        }
        public void DisplayRole()
        {
            Console.WriteLine("From DisplayRole");
        }
        public void DisplayDetails()
        {
            Console.WriteLine("From DisplayDetails");
        }
    }

    // sealed class don't allow inheritance, sealed methods can't br override 
    sealed internal class ObjectOriented
    {
        private static void Display(string s1)
        {
            Console.WriteLine(s1);
        }
        private static void Display(string s1, string s2)
        {
            Console.WriteLine($"{s1}, {s2}");
        }
        public static void Main(string[] args)
        {
            IEmployee emp1 = new Employee();
            emp1.DisplayName();
            Employee emp2 = new Employee();
            emp2.DisplayName();

            Display("Hello");
            Display("Hello", "World");


            SportsCar s = new SportsCar();
            s.StartCar();
            s.Test();


            Test.Test1 obj1 = new Test.Test1();
            obj1.PublicDisplay("test");

        }
    }
}
