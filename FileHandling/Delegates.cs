namespace FileHandling
{
    delegate int delegateAddTwoInts(int x, int y);
    delegate int delegateTowInts(int x, int y);
    delegate string delegateAdd<T>(T x, T y);
    delegate int DelegateAnonymous(int x, int y, int z);
    delegate void Print<T>(T msg);
    delegate int LambdaAdd(int x, int y, int z);

    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Dept { get; set; }
        public int Score { get; set; }

    }
    internal class Delegates
    {
        public static void Main(string[] args)
        {

            List<Student> studentList = new List<Student>();
            studentList.Add(new Student(){ Id=1,Name="Yuvateja",Age=22,Dept="CSE",Score=85});
            studentList.Add(new Student() { Id = 2, Name = "Harish", Age = 19, Dept = "ECE", Score = 90 });
            studentList.Add(new Student() { Id = 3, Name = "Siva", Age = 17, Dept = "CSE", Score = 85 });
            studentList.Add(new Student() { Id = 4, Name = "Vinay", Age = 21, Dept = "EEE", Score = 95 });

            foreach (var student in studentList)
            {
                Console.WriteLine($"{student.Id} Name: {student.Name}, Dept:{student.Dept}, Score:{student.Score}");
            }
            List<Student> newStudList = studentList.OrderBy(stud => stud.Age>=20).ToList();
            Console.WriteLine();
            foreach (var student in newStudList)
            {
                Console.WriteLine($"{student.Id} Name: {student.Name}, Age:{student.Age}, Dept:{student.Dept}, Score:{student.Score}");
            }

            delegateAddTwoInts d1 = AddTwoInts;
            Console.WriteLine(d1(10, 20));
            Console.WriteLine(d1.Invoke(20, 30));
             // ! Multicast delegate
            delegateTowInts d2 = AddTwoInts;
            d2 += DiffTowInts;
                        Console.WriteLine(d2(10, 20));
                        Console.WriteLine(d2.Invoke(20, 30));
            var res = d2.GetInvocationList().Select(x => x.DynamicInvoke(10, 20));
            foreach (var item in res)
            {
                Console.WriteLine(item);
            }
            Delegate[] delegateArr = d2.GetInvocationList();
            foreach (Delegate item in delegateArr)
            {
                Console.WriteLine(item.DynamicInvoke(20, 20)); ;
            }
            delegateAdd<int> intDelegate = Add;
            Console.WriteLine(intDelegate(100,100));

            // ! Anonymous
            DelegateAnonymous addThree = delegate (int x, int y, int z) { return x + y + z; };
            Console.WriteLine(addThree(1, 2, 3));
            Print<string> printStr = delegate (string msg) { Console.Write(msg + " "); };
            Print<List<string>> printStrList = delegate (List<string> strArr)
            {
                foreach (var item in strArr)
                {
                    Console.WriteLine(item);
                }
            };
            printStr("Hello");
            var strArr = new List<string>() { "Hi", "Hello", "Cool" };
            printStrList(strArr);
            // ! Lambda
            LambdaAdd addLambda = (a, b, c) => a + b + c;
            Console.WriteLine(addLambda(1, 2, 3));
            Print<string> printStrLambda = (str) => Console.WriteLine(str);
            printStrLambda("Hello World!");
            //! Lambda Without Delegate
            var addNum = (int a, int b) => a + b;
            Console.WriteLine(addNum(5, 6));

            List<int> nums = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16 };
            List<int> even = nums.FindAll(x => x % 2 == 0);
            foreach (var item in even)
            {
                Console.Write(item + " ");
            }


        }
        public static int AddTwoInts(int x, int y)
        {
            return x + y;
        }
        public static int DiffTowInts(int x, int y)
        {
            return x - y;
        }
        public static string Add<T>(T x, T y)
        {
            return x.ToString() + y.ToString();
        }
    }
}