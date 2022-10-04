using System;

namespace OOP_3_3 // в процесі
{
    class Point
    {
        // поля класу
        public int x;
        public int y;
        public string nameFigure;

        // конструктор
        public Point(int x, int y, string nameFigure)
        {
            this.x = x;
            this.y = y;
            this.nameFigure = nameFigure;
        }

        // властивості
        public int X
        {
            get { return x; }
        }
        public int Y
        {
            get { return y; }
        }
        public string NameFigure
        {
            get { return nameFigure; }
        }
    }
    class Figure : Point
    {
        public Point A;
        public Point B;
        public Point C;
        public Point D;
        public Point E;
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Default;

            /* Address someAddress = new Address("02254", "Ukraine", "Kyiv", "Zakrevskogo", 53, 112); // створення екземпляру класу
            // звернення до get
            // виведення адреси на екран
            Console.WriteLine($"{someAddress.Index}"); */

            Console.ReadLine();
        }
    }
}