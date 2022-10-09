using System;

namespace OOP_3_3
{
    class Point
    {
        // поля класу
        public int _x;
        public int _y;
        public string _nameFigure;

        public Point() {}// конструктор без параметрів

        // конструктор з параметрами
        public Point(int x, int y, string nameFigure)
        {
            _x = x;
            _y = y;
            _nameFigure = nameFigure;
        }

        // властивості Point
        public int X
        {
            get { return _x; }
        }

        public int Y
        {
            get { return _y; }
        }

        public string NameFigure
        {
            get { return _nameFigure; }
        }
    }
    class Figure : Point
    {
        public Point _a, _b, _c, _d, _e;

        // контруктор для побудови трикутника
        public Figure(Point a, Point b, Point c)
        {
            Console.WriteLine($"{a.NameFigure}");
            _a = a;
            _b = b;
            _c = c;
            _d = new Point(0, 0, a.NameFigure);
            _e = new Point(0, 0, a.NameFigure);
            string nameFigure = NameFigure;
        }

        // конструктор для побудови чотирикутника
        public Figure(Point a, Point b, Point c, Point d) : this(a, b, c)
        {
            _d = d;
        }

        public Figure(Point a, Point b, Point c, Point d, Point e) : this(a, b, c, d)
        {
            _e = e;
        }

        public static double LengthSide(Point a, Point b)
        {
            return Math.Sqrt(Math.Pow(a.X - b.X, 2) + Math.Pow(a.Y - b.Y, 2));
        }

        public void PerimeterCalculator()
        {
            int v;
            Console.WriteLine("Виберіть тип фігури \nv = 1, якщо це трикутник, " +
                                                  "\nv = 2, якщо це чотирикутник");
            v = Convert.ToInt32(Console.ReadLine());
            if (v == 1)
            {
                double perimeter = LengthSide(_a, _b) + LengthSide(_b, _c) + LengthSide(_c, _a);
                Console.WriteLine($"Периметр трикутника: {perimeter}");
            }

            if (v == 2)
            {
                double perimeter = LengthSide(_a, _b) + LengthSide(_b, _c) + LengthSide(_c, _d) + LengthSide(_d, _a);
                Console.WriteLine($"Периметр чотирикутника: {perimeter}");
            }

            else
            {
                double perimeter = LengthSide(_a, _b) + LengthSide(_b, _c) + LengthSide(_c, _d) + LengthSide(_d, _e) + LengthSide(_e, _a);
                Console.WriteLine($"Периметр п'ятикутника: {perimeter}");
            }
        }
    }

    class Program
    {
        static void GetAnswer(int option)
        {
            string figureName = "Трикутник";

            if (option == 2)
                figureName = "Чотирикутник";
            else
                figureName = "П'ятикутник";

            Point a = new Point(2, 2, figureName);
            Point b = new Point(1, 5, figureName);
            Point c = new Point(3, 8, figureName);
            Point d = new Point(4, 7, figureName);
            Point e = new Point(5, 3, figureName);

            if (option == 1)
            {
                Figure figure = new Figure(a, b, c);
                figure.PerimeterCalculator();
            }
            else if (option == 2)
            {
                Figure figure = new Figure(a, b, c, d);
                figure.PerimeterCalculator();
            }
            else
            {
                Figure figure = new Figure(a, b, c, d, e);
                figure.PerimeterCalculator();
            }
        }

        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Default;

            while (true)
            {
                Console.Write(new string('=', 50) + "\n1. Трикутник\n2. Чотирикутник\n3. П'ятикутник\nОберіть фігуру: ");
                int option = Convert.ToInt32(Console.ReadLine());

                switch (option)
                {
                    case 1 or 2 or 3: GetAnswer(option); break;
                    default: Console.WriteLine("Помилка"); break;
                }

                Console.ReadLine();
            }
        }
    }
}