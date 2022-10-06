using System;

namespace OOP_3_2
{
    class Book
    {
        
    }
    class Title : Book
    {
        public string title; // поле

        public Title(string title) // конструктор
        {
            this.title = title;
        }

        public void ShowTitle() // метод
        {
            Console.WriteLine(title);
        }
    }
    class Author : Title
    {
        public string author; // поле

        public Author(string author, string title) : base(title) // контруктор
        {
            this.author = author;
        }

        public void ShowAuthor() // метод
        {
            Console.WriteLine(author);
        }
    }
    class Content : Author
    {
        public string content; // поле

        public Content(string content, string author, string title) : base(author, title) // контруктор
        {
            this.content = content;
        }

        public void ShowContent() // метод
        {
            Console.WriteLine(content);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Default;

            Content content = new Content("fantasy", "J.K.Rowling", "Harry Potter"); // створення екземпляру класу

            Console.WriteLine("Книжка: ");

            Console.ForegroundColor = ConsoleColor.Red;
            content.ShowTitle();

            Console.ForegroundColor = ConsoleColor.Blue;
            content.ShowAuthor();

            Console.ForegroundColor = ConsoleColor.Green;
            content.ShowContent();

            Console.ReadLine();
        }
    }
}