using System;

namespace OOP_3_4
{
    class Invoice
    {
        // поля класу
        private int account;
        private string customer;
        private string provider;
        private int quantity;
        private double price;

        // конструктор
        public Invoice(int account, string customer, string provider, int qty, double price)
        {
            this.account = account;
            this.customer = customer;
            this.provider = provider;
            Quantity = qty;
            Price = price;
        }

        // властивості
        public int Account
        {
            get { return account; }
        }

        public string Customer
        {
            get { return customer; }
        }

        public string Provider
        {
            get { return provider; }
        }

        public int Quantity
        {
            get { return quantity; }
            set
            {
                if (value > 0)
                {
                    quantity = value;
                }
                else
                {
                    quantity = 1;
                    Console.WriteLine("Помилка!");
                }
            }
        }

        public double Price
        {
            get { return price; }
            set
            {
                if (value > 0)
                {
                    price = value;
                }
                else
                {
                    price = 1;
                    Console.WriteLine("Помилка!");
                }
            }
        }

        // метод
        public double GetInvoiceAmount()
        {
            return Quantity * Price;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Default;
            int qty;
            double price;
            Console.WriteLine("Введіть кількість одиниць товару: ");
            qty = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введіть ціну одиниці товару (price): ");
            price = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();

            Invoice invoice = new Invoice(260012345, "Fenix", "Platon", qty, price); // створення екземпляру класу

            Console.WriteLine($"Account: {invoice.Account}");
            Console.WriteLine($"Customer: {invoice.Customer}");
            Console.WriteLine($"Provider: {invoice.Provider}");
            Console.WriteLine($"Кількість: {invoice.Quantity}");
            Console.WriteLine($"Ціна: {invoice.Price}");

            Console.WriteLine();
            Console.WriteLine($"Вартість замовлення без ПДВ: {invoice.GetInvoiceAmount()}");
            Console.WriteLine($"Вартість замовлення з ПДВ: {invoice.GetInvoiceAmount() * 1.2}");

            Console.ReadLine();
        }
    }
}