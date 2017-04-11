using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Program
    {
        static double InputDouble()
        {
            bool input = true;
            double a = 0;

            while (input)
            {
                string str = Console.ReadLine();

                try
                {
                    a = double.Parse(str);
                    input = false;
                }
                catch (Exception)
                {
                    Console.WriteLine("Input error!");
                }
            }

            return a;
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
        static void AddressTask()
        {
            Address address = new Address();
            address.FillAll();
            address.PrintAll();
        }
        static void RectangleTask()
        {
            Console.WriteLine("Enter the first side of rectangle.");
            double side1, side2;
            side1 = InputDouble();
            Console.WriteLine("Enter the second side of rectangle.");
            side2 = InputDouble();
            Rectangle rectangle = new Rectangle(side1, side2);
            Console.WriteLine("Area: {0}", rectangle.Area);
            Console.WriteLine("Perimeter: {0}", rectangle.Perimeter);
        }
        static void BookTask()
        {
            Console.WriteLine("Enter a title of the book:");
            string title = InputString();
            Console.WriteLine("Enter an author of the book:");
            string author = InputString();
            Console.WriteLine("Enter a content of the book:");
            string content = InputString();
            Book book = new Book(title, author, content);
            book.PrintAll();
        }
        static void FigureTask()
        {
            Console.WriteLine("Enter a number of points:");
            int num = InputInt();
            while (num < 3 || num > 5)
            {
                Console.WriteLine("Number must be 3-5, try again:");
                num = InputInt();
            }
            List<Point> points = new List<Point> { };
            for (int i = 0; i < num; i++)
            {
                Console.Write("{0}. ", i + 1);
                Console.WriteLine("Enter a name of point:");
                string name = InputString();
                Console.WriteLine("Enter an x koord:");
                int x = InputInt();
                Console.WriteLine("Enter an y koord:");
                int y = InputInt();
                points.Add(new Point(name, x, y));
            }

            Figure figure;
            switch (num)
            {
                case 3:
                    figure = new Figure(points[0], points[1], points[2]);
                    break;
                case 4:
                    figure = new Figure(points[0], points[1], points[2], points[3]);
                    break;
                default:
                    figure = new Figure(points[0], points[1], points[2], points[3], points[4]);
                    break;
            }

            Console.Write("Figure's name: ");
            foreach (Point point in figure.points)
            {
                Console.Write(point.Name);
            }

            Console.Write("\nPerimeter: {0}\n", figure.Perimeter);
        }
        static void UserTask()
        {
            Console.WriteLine("Enter a login of the user:");
            string login = InputString();
            Console.WriteLine("Enter a name of the user:");
            string name = InputString();
            Console.WriteLine("Enter a surname of the user:");
            string surname = InputString();
            Console.WriteLine("Enter an age of the user:");
            int age = InputInt();
            User user = new User(login, name, surname, age);
            user.Output();
        }
        static void ConverterTask()
        {
            double usd, eur, rub;
            Console.Write("Enter a rate for USD: ");
            usd = InputDouble();
            Console.Write("Enter a rate for EUR: ");
            eur = InputDouble();
            Console.Write("Enter a rate for RUB: ");
            rub = InputDouble();
            Converter converter = new Converter(usd, eur, rub);
            int menu = -1;
            while (menu != 0)
            {
                Console.WriteLine("Convert:");
                Console.WriteLine("[1] From UAH to USD\t[4] From USD to UAH");
                Console.WriteLine("[2] From UAH to EUR\t[5] From EUR to UAH");
                Console.WriteLine("[3] From UAH to RUB\t[6] From RUB to UAH");
                Console.WriteLine("[0] Exit");
                menu = InputInt();

                double amount = 0;
                if (menu != 0)
                {
                    Console.WriteLine("Enter an amount:");
                    amount = InputDouble();
                }

                switch (menu)
                {
                    case 1:
                        Console.WriteLine("Result: {0:.00}", converter.UAH_to_USD(amount));
                        break;
                    case 2:
                        Console.WriteLine("Result: {0:.00}", converter.UAH_to_EUR(amount));
                        break;
                    case 3:
                        Console.WriteLine("Result: {0:.00}", converter.UAH_to_RUB(amount));
                        break;
                    case 4:
                        Console.WriteLine("Result: {0:.00}", converter.USD_to_UAH(amount));
                        break;
                    case 5:
                        Console.WriteLine("Result: {0:.00}", converter.EUR_to_UAH(amount));
                        break;
                    case 6:
                        Console.WriteLine("Result: {0:.00}", converter.RUB_to_UAH(amount));
                        break;
                    case 0:
                        break;
                    default:
                        Console.WriteLine("Wrong input!");
                        break;
                }
            }
        }
        static void EmployeeTask()
        {
            Console.WriteLine("Enter a surname of the employee:");
            string surname = InputString();
            Console.WriteLine("Enter a name of the employee:");
            string name = InputString();
            Employee employee = new Employee(surname, name);
            bool input = true;
            string position = "";

            while (input)
            {
                Console.WriteLine("Enter a position (guard, manager or principal):");
                position = InputString();
                if (position != "guard" && position != "manager" && position != "principal")
                {
                    Console.WriteLine("Input error!");
                }
                else
                    input = false;
            }

            Console.WriteLine("Enter an experience (number):");
            int experience = InputInt();
            employee.Calculate(position, experience);
            employee.Output();
        }
        static void InvoiceTask()
        {
            Invoice invoice = new Invoice();
            Console.WriteLine("Would you like to calculate..?");
            Console.WriteLine("[1] With NDS");
            Console.WriteLine("[2] Without NDS");
            int menu = -1;
            while (menu != 1 && menu != 2)
            {
                menu = InputInt();
                if (menu == 1)
                    Console.WriteLine("Total cost: {0:.00}", invoice.CalculateCost(true));
                else if (menu == 2)
                    Console.WriteLine("Total cost: {0:.00}", invoice.CalculateCost(false));
                else
                    Console.WriteLine("Input error! Try again:");
            }
        }

        static void Main(string[] args)
        {
            int menu = -1;
            while (menu != 0)
            {
                Console.WriteLine("[1] Address\t[5] User");
                Console.WriteLine("[2] Rectangle\t[6] Converter");
                Console.WriteLine("[3] Book\t[7] Employee");
                Console.WriteLine("[4] Figure\t[8] Invoice\n");
                Console.WriteLine("[0] Exit\n");
                Console.WriteLine("Choose a task:");
                menu = InputInt();
                Console.Clear();

                switch (menu)
                {
                    case 1:
                        AddressTask();
                        break;
                    case 2:
                        RectangleTask();
                        break;
                    case 3:
                        BookTask();
                        break;
                    case 4:
                        FigureTask();
                        break;
                    case 5:
                        UserTask();
                        break;
                    case 6:
                        ConverterTask();
                        break;
                    case 7:
                        EmployeeTask();
                        break;
                    case 8:
                        InvoiceTask();
                        break;
                    case 0:
                        return;
                    default:
                        Console.WriteLine("Input error! Try again.");
                        break;
                }

                Console.WriteLine("\nPress any key to continue...");
                Console.ReadKey();
                Console.Clear();
            }

            Console.ReadKey();
        }
    }
}
