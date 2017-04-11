using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Invoice
    {
        readonly int account;
        readonly string customer;
        readonly string provider;
        string article;
        int quantity;

        public Invoice()
        {
            Console.WriteLine("Enter an account:");
            account = InputInt();
            Console.WriteLine("Enter a customer:");
            customer = InputString();
            Console.WriteLine("Enter a provider:");
            provider = InputString();
            Console.WriteLine("Enter an article:");
            article = InputString();
            Console.WriteLine("Enter a quantity:");
            quantity = InputInt();
        }
        static string InputString()
        {
            bool input = true;
            string a = "";

            while (input)
            {
                a = Console.ReadLine();
                if (a != "" && a != null)
                {
                    input = false;
                }
                else
                {
                    Console.WriteLine("Input error!");
                }
            }

            return a;
        }
        static int InputInt()
        {
            bool input = true;
            int a = 0;

            while (input)
            {
                string str = Console.ReadLine();

                try
                {
                    a = int.Parse(str);
                    input = false;
                }
                catch (Exception)
                {
                    Console.WriteLine("Input error!");
                }
            }

            return a;
        }
        public double CalculateCost(bool IsWithNDS)
        {
            if (IsWithNDS)
            {
                //nothing to do with real NDS :)
                return 2 * (account * quantity) - ((account * quantity) / 1.2);
            }
            else
            {
                return (account * quantity);
            }
        }
    }
}
