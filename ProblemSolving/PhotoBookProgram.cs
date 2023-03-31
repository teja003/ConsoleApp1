using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving
{
    public class PhotoBook
    {
        public int totalPages;
        public PhotoBook() {
            this.totalPages = 16;
        }
        public PhotoBook(int totalPages)
        {
            this.totalPages = totalPages;
        }
        public int GetNumberPages()
        {
            return this.totalPages;
        }
    }

    public class AddPhotoBook : PhotoBook
    {

        public AddPhotoBook() : base(64) { }
    }

    internal class PhotoBookProgram
    {
        public static void Main(string[] args)
        {
            PhotoBook smBook = new PhotoBook();
            PhotoBook mdBook = new PhotoBook(32);
            AddPhotoBook lgBook = new AddPhotoBook();
            Console.WriteLine($"{smBook.GetNumberPages()} Pages");
            Console.WriteLine($"{mdBook.GetNumberPages()} Pages");
            Console.WriteLine($"{lgBook.GetNumberPages()} Pages");

        }
    }
}
