using System;

namespace BasicLesson1._2
{
    class Book
    {
        string field;

        public Book (string field)
        {
            this.field = field;
        }

        public void Show()
        {
            Console.WriteLine(field);
        }
    }

    class Author
    {
        string field;

        public Author(string field)
        {
            this.field = field;
        }

        public void Show()
        {
            Console.WriteLine(field);
        }
    }

    class Content
    {
        string field; 

        public Content(string field)
        {
            this.field = field;
        }
        public void Show()
        {
            Console.WriteLine(field);
        }
    }

    class Program
    {
        static void Main()
        {
            Book book = new Book("dfddfdf");

            book.Show();

            Author autor = new Author("dfdf");
            autor.Show();

            Content content = new Content("sfsdf");
            content.Show();

            Console.ReadKey();
        }
    }
}
