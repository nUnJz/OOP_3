using System;

namespace Polygon
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangle triangle = new Triangle(new Point(1, 1), new Point(2, 3), new Point(4, 1));
            Rectangle rectangle = new Rectangle(new Point(4, 4), new Point(7, 1));

            List<Figure> figures = new List<Figure>() { triangle, rectangle };

            foreach (var item in figures)
            {
                Console.WriteLine("Square of the {0} = {1}", item.GetType().Name, item.GetSquare());
                Console.WriteLine("Perimeter of the {0} = {1}\n", item.GetType().Name, item.GetPerimeter());
            }

            Console.ReadLine();
        }
    }

    struct Point
    {
        public int x;
        public int y;

        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
    }
    abstract class Figure
    {
        public abstract double GetSquare();
        public abstract double GetPerimeter();

        protected double GetLength(Point x, Point y)
        {
            return Math.Sqrt(Math.Pow(y.x - x.x, 2) + Math.Pow(y.y - x.y, 2));
        }
    }
    class Triangle : Figure
    {
        private Point x;
        private Point y;
        private Point z;

        public Triangle(Point x, Point y, Point z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        public override double GetSquare()
        {
            double perimeter = GetPerimeter() / 2;

            return Math.Sqrt(perimeter * (perimeter - GetLength(x, y)) * (perimeter - GetLength(y, z)) * (perimeter - GetLength(x, z)));
        }

        public override double GetPerimeter()
        {
            return GetLength(x, y) + GetLength(y, z) + GetLength(x, z);
        }
    }
    class Rectangle : Figure
    {
        private Point a;
        private Point b;
        private Point c;
        private Point d;

        public Rectangle(Point a, Point d)
        {
            this.a = a;
            this.d = d;
            b = new Point(d.x, a.y);
            c = new Point(a.x, d.y);
        }

        public override double GetPerimeter()
        {
            return (GetLength(a, b) + GetLength(a, d)) * 2;
        }
        public override double GetSquare()
        {
            return GetLength(a, b) * GetLength(a, d);
        }
    }
}