using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace ConsoleApp1
{
    class book
    {
         string titel;
         string aurhor;
         string isbn;
         bool isavailble;

        public book(string titel, string aurhor, string isbn)
        {
            this.titel = titel;
            this.aurhor = aurhor;
            this.isbn = isbn;
            this.isavailble = true;
        }

        public string Title { get { return titel; } set { titel = value; } }
        public string Aurhor { get { return aurhor; } set { aurhor = value; } }
        public string Isbn { get { return isbn; } set { isbn = value; } }
        public bool Isavailbel { get { return isavailble; } set { isavailble = value; } }
    }
    class library
    {
        List<book> books;

        public library()
        {
            books = new List<book>();
        }
        public void AddBook(book Book)
        {
            books.Add(Book);
        }
        public string SearchBook(string keyword)
        {
            for (int i = 0; i < books.Count; i++)
            {
                if (books[i].Title == keyword || books[i].Aurhor == keyword)
                {
                    //Console.WriteLine($" the titel :{books[i].Titel}");
                    //Console.WriteLine($" the auther :{books[i].Aurhor}");
                    return ($" the titel :{books[i].Title}" + ", " + 
                        $" the auther :{books[i].Aurhor}");
                }
            }
           // Console.WriteLine("book not found");
            return "not found book";
        }
        public string BorrowBook(string title)
        {
            for (int i = 0; i < books.Count; i++)
            {
                if (books[i].Title == title && books[i].Isavailbel)
                {
                    books[i].Isavailbel = false;
                    //Console.WriteLine($" the name book :{books[i].Titel}");
                    return ($" the name book :{books[i].Title}");
                }
            }
            //Console.WriteLine(" not book found or not borrowbook");
            return (" not book found or not borrowbook");
        }
        public string ReturnBook(string title)
        {
            for (int i  = 0;i < books.Count; i++)
            {
                if (books[i].Title == title && !books[i].Isavailbel)
                {
                    books[i].Isavailbel = true;
                    //Console.WriteLine($" the book name :{books[i].Titel}" + " , "+ 
                    //    $" the auther :{books[i].Aurhor}"+ " , " + $" the isbn :{books[i].Isbn}");
                    return ($" the book name :{books[i].Title}" + " , " +
                       $" the auther :{books[i].Aurhor}"+ " , " + $" the isbn :{books[i].Isbn}");
                }
            }
            //Console.WriteLine("not found");
            return ("not found");
        }

    }


    internal class Program
    {
        static void Main(string[] args)
        {
            library Library = new();
            book b1 = new("c#", "hassan", "1111");
            book b2 = new("clean cood ", "ali ", "324");
            book b3 = new("c++", "elmasry", " 8860");
           
            Library.AddBook(b1);
            Library.AddBook(b2);
            Library.AddBook(b3);
            Console.WriteLine(" -----search book------");
            Console.WriteLine(Library.SearchBook("c#"));
            Console.WriteLine("------borrow book-------");
            Console.WriteLine(Library.BorrowBook("c#"));
            Console.WriteLine("------return book------");
            Console.WriteLine(Library.ReturnBook("c#"));
            // Library.SearchBook("c#");
            //Library.BorrowBook("c#");
            //Library.ReturnBook("c#");


        }
    }
}
