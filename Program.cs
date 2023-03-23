// See https://aka.ms/new-console-template for more information
namespace ConsoleApp1
{
    class Student
    {
        public int id;
        public string name;
        public int age;
        public string dept;
        public float grade;
        public Student(int id, string name, int age, string dept, float grade)
        {
            this.id = id;
            this.name = name;
            this.age = age;
            this.dept = dept;
            this.grade = grade;
        }
        public void DisplayStudentDetails()
        {
            Console.WriteLine($"{this.name} age is {this.age} from {this.dept} dept");
        }
        public void IncrementAge()
        {
            this.age+= 1;
        }
    }
    internal class Program
    {
        public static void Main(string[] args)
        {
            // Exception Handling
            // handle the error with try, catch, finally
            // try block expect catch or final
            // we can chain multiple catch blocks, Exception class should be last catch block
            // final block should be last block. the code inside final block should execute neither error occurs nor error not occurs
            int a = 10;
            int b = 0;
            // int c = a / b; //throw error
            int[] arr = { 1,2,3,4};
            try
            {
                //int c = a / b;
                int d = arr[4];
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine("Try with low index");
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("Can't divide the number with 0");
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }finally { 
                Console.WriteLine("Code inside Finally"); 
            }
            /*
            ConstructorAndDestructor cd1 = new ConstructorAndDestructor();
            cd1.CallMe();
            */
            /*
            Student s1 = new Student(1, "Yuvateja", 21, "CSE", 8.5f);
            s1.DisplayStudentDetails();
            s1.IncrementAge();
            s1.IncrementAge();
            s1.DisplayStudentDetails();
            */
            /*
            int[] arr1 = { 1, 2, 3 };
            int[,] arr2 = { { 1, 2, 3 }, { 4, 5, 6 } };
            int[,,] arr3 = { { {1,2 },{3,4 } },{ {5,6 },{7,8 } } };
            int[] arr11 = new int[8];
            foreach (int mat in arr3)
            {
                Console.Write(mat+" ");
                arr11[mat-1] = mat;
            }
            Console.WriteLine("[{0}]",string.Join(", ",arr11));
            */
        }
    }
}