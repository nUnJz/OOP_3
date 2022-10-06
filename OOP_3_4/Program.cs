using System;

namespace OOP_3_4
{
    class Invoice
    {
        // поля класу
        private int account;
        private string customer;
        private string provider;
        private string article;
        private int quantity;

        // конструктор
        public Invoice(int account, string customer, string provider, string article, int qty)
        {
            this.account = account;
            this.customer = customer;
            this.provider = provider;
            this.article = article;
            Quantity = qty;
        }

        // властивості
        public int Account
        {
            get { return account; }
            /* set
            {
                if (value > 0)
                {
                    account = value;
                }
                else
                {
                    Console.WriteLine("Помилка!");
                }
            } */
        }

        public string Customer
        {
            get { return customer; }
        }

        public string Provider
        {
            get { return provider; }
        }

        public string Article
        {
            get { return article; }
            set { article = value; }
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
                    Console.WriteLine("Помилка!");
                }
            }
        }

        // метод
        public int GetInvoiceAmount()
        {
            return Quantity * Account;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Default;
            int qty;
            int account;
            Console.WriteLine("Введіть кількість одиниць товару: ");
            qty = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введіть ціну одиниці товару (account): ");
            account = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            Invoice invoice = new Invoice(account, "Fenix", "Platon", "NKBSM39BL", qty); // створення екземпляру класу

            Console.WriteLine($"Ціна: {invoice.Account}");
            Console.WriteLine($"Customer: {invoice.Customer}");
            Console.WriteLine($"Provider: {invoice.Provider}");
            Console.WriteLine($"Article: {invoice.Article}");
            Console.WriteLine($"Кількість: {invoice.Quantity}");

            Console.WriteLine();
            Console.WriteLine($"Вартість замовлення без ПДВ: {invoice.GetInvoiceAmount()}");
            Console.WriteLine($"Вартість замовлення з ПДВ: {invoice.GetInvoiceAmount() * 1.2}");

            Console.ReadLine();
        }
    }
}