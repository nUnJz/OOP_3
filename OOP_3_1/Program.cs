using System;

namespace OOP_3_1
{
    class Rectangle
    {
        // поля класу
        public double side1;
        public double side2;

        // конструктор
        public Rectangle(double side1, double side2)
        {
            this.side1 = side1;
            this.side2 = side2;
        }

        // властивості
        public double Area
        {
            get { return Area; }
        }

        public double Perimeter
        {
            get { return Perimeter; }
        }

        // методи
        public double AreaCalculator()
        {
            return side1 * side2;
        }

        public double PerimeterCalculator()
        {
            return (side1 + side2) * 2;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Default;

            double side1; // сторона side1 прямокутника
            double side2; // сторона side2 прямокутника

            Console.WriteLine("Введіть довжину сторони прямокутника side1: ");
            side1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введіть довжину сторони прямокутника side2: ");
            side2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();

            Rectangle rectangle = new Rectangle(side1, side2); // створення екземпляру класу

            Console.WriteLine($"Сторона прямокутника side1: {rectangle.side1}");
            Console.WriteLine($"Сторона прямокутника side2: {rectangle.side2}");
            Console.WriteLine();

            Console.WriteLine($"Площа прямокутника: {rectangle.AreaCalculator()}");
            Console.WriteLine($"Периметр прямокутника: {rectangle.PerimeterCalculator()}");

            Console.ReadLine();
        }
    }
}