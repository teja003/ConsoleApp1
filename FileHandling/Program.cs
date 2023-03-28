using System.Text;


/*StreamReader sr = new StreamReader(file);
string line = sr.ReadLine();
sr.Close();
file.Close();
Console.WriteLine(line);*/

namespace FileHandling
{
    public class Program
    {
        public static void main(string[] args)
        {
            string path = "C:\\Users\\HP\\Desktop\\New folder\\C#\\FileHandling\\file.txt";
            string data = "Hello! New Text data!!";
            FileInfo fi = new FileInfo("C:\\Users\\HP\\Desktop\\New folder\\C#\\FileHandling\\file2.txt");
            if (fi.Exists )
            {
                fi.Delete();
            } else
            {
                fi.Create();
            }
            string dirPath = "C:\\Users\\HP\\Desktop\\New folder\\C#\\FileHandling\\cool";
            DirectoryInfo dir = new DirectoryInfo(dirPath);
            if(dir.Exists )
            {
                dir.Delete();
            }else
            {
                dir.Create();
            }
        }
        public static void WritingUsingFileStream(string path, string data)
        {
            FileStream file = new FileStream(path, FileMode.OpenOrCreate, FileAccess.ReadWrite);
            byte[] byteData = Encoding.UTF8.GetBytes(data);
            file.Write(byteData);
            file.Close();
        }
        public static void WritingUsingFile(string path, string data)
        {
            File.WriteAllText(path, data);
        }

        public static void WritingUsingStreamWriter(string path, string data)
        {
            FileStream file = new FileStream(path, FileMode.OpenOrCreate, FileAccess.ReadWrite);
            StreamWriter writer = new StreamWriter(file);
            writer.Write(data);
            writer.Close();
            file.Close();
        }

        public static void WritingUsingTextWriter(string path, string data)
        {
            using (TextWriter textWriter = File.CreateText(path))
            {
                textWriter.Write(data);
            }
        }
    }

    
}