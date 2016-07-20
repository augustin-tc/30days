using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProgrammation.Day13
{
    abstract class Book
    {
        protected String title;
        protected String author;

        public Book(String t, String a)
        {
            title = t;
            author = a;
        }
        public abstract void display();

    }

    class MyBook : Book
    {
        protected int Price;

        public MyBook(string t, string a, int p) : base(t, a)
        {
            Price = p;
        }

        public override void display()
        {
            Console.WriteLine("Title: " + 
                title + "\nAuthor: " + author + "\nPrice: " + Price);
        }
    }
}
