using System;

namespace OOP_3_3 // в процесі
{
    class Point
    {
        // поля класу
        public int x;
        public int y;
        public string nameFigure;

        // конструктор з параметрами
        public Point(int x, int y, string nameFigure)
        {
            this.x = x;
            this.y = y;
            this.nameFigure = nameFigure;
        }

        public Point() // конструктор без параметрів
        {
            x = y = 0;
            nameFigure = "";
        }

        // властивості Point
        public int XX
        {
            get { return x; }
        }
        public int YY
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
        public Point a;
        public Point b;
        public Point c;
        public Point d;
        public Point e;

        /* public Figure()
        {
            Point A = null;
            Point B = null;
            Point C = null;
            Point D = null;
            Point E = null;
        } */

        // контруктор для побудови трикутника
        public Figure(Point a, Point b, Point c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
            // Point d = null;
            // Point e = null;
        }

        // конструктор для побудови чотирикутника
        public Figure(Point a, Point b, Point c, Point d)
        {
            this.a = a;
            this.b = b;
            this.c = c;
            this.d = d;
            // Point e = null;
        }

        // контруктор для побудови п'ятикутника
        public Figure(Point a, Point b, Point c, Point d, Point e)
        {
            this.a = a;
            this.b = b;
            this.c = c;
            this.d = d;
            this.e = e;
        }

        public static double LengthSide(Point a, Point b)
        {
            double len;
            len = Math.Sqrt((a.x - b.x) * (a.x - b.x) + (a.y - b.y) * (a.y - b.y));
            return len;
        }

        public void PerimeterCalculator()
        {
            double perimeter = LengthSide(a, b) + LengthSide(b, c) + LengthSide(c, d) + LengthSide(d, e) + LengthSide(e, a);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Default;

            Point p = new Point();
            p = new Point(2, 2, "П'ятикутник");

            Figure f = new Figure(); // створення екземпляру класу
            f = new Figure();

            // Figure figure1 = new Figure(Point(2, 2), Point(5, 3), Point(1, 5), "Трикутник");

            Console.ReadLine();
        }
    }
}