using System;
using System.Collections.Generic;
//using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Training_Sorokina
{
    class Program
    {
        static void Task11()
        {
            int a, b;
            Console.WriteLine("Enter a first number:");
            try
            {
                a = int.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("Bad input!");
                Console.ReadKey();
                return;
            }
            Console.WriteLine("Enter a second number:");
            try
            {
                b = int.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("Bad input!");
                Console.ReadKey();
                return;
            }

            if (a > b)
                Console.WriteLine("{0} is greater", a);
            else if (b > a)
                Console.WriteLine("{0} is greater", b);
            else
                Console.WriteLine("Numbers are equal");
            
            Console.ReadKey();
        }
        static void Task12()
        {
            Console.WriteLine("Type \"mew\" or \"bark\":");
            
            string s = Console.ReadLine();
            
            if (s == "mew")
                Console.WriteLine("Feed the cat");
            else if (s == "bark")
                Console.WriteLine("Take a walk with the dog");
            else
                Console.WriteLine("We don't know such animal");
            
            Console.ReadKey();
        }
        static void Task13()
        {
            int n;
            Console.WriteLine("Enter a number of a month:");

            try
            {
                n = int.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("Bad input!");
                Console.ReadKey();
                return;
            }

            switch (n)
            {
                case 12:
                case 1:
                case 2:
                    Console.WriteLine("Winter");
                    break;
                case 3:
                case 4:
                case 5:
                    Console.WriteLine("Spring");
                    break;
                case 6:
                case 7:
                case 8:
                    Console.WriteLine("Summer");
                    break;
                case 9:
                case 10:
                case 11:
                    Console.WriteLine("Autumn");
                    break;
                default:
                    Console.WriteLine("There is no such month on this planet");
                    break;
            }

            Console.ReadKey();
        }
        static void Task14()
        {
            int n;
            Console.WriteLine("Enter a number 0 or 1:");

            try
            {
                n = int.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("Bad input!");
                Console.ReadKey();
                return;
            }

            if ((n != 0) && (n != 1))
            {
                Console.WriteLine("Bad input!");
                Console.ReadKey();
                return;
            }

            Console.WriteLine((n == 1) ? "Good" : "Bad");
            Console.ReadKey();
        }
        static void Task15()
        {
            int n;
            Console.WriteLine("Enter a number of a day:");

            try
            {
                n = int.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("Bad input!");
                Console.ReadKey();
                return;
            }

            switch (n)
            {
                case 1:
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Wednesday");
                    break;
                case 4:
                    Console.WriteLine("Thursday");
                    break;
                case 5:
                    Console.WriteLine("Friday");
                    break;
                case 6:
                    Console.WriteLine("Saturday");
                    break;
                case 7:
                    Console.WriteLine("Sunday");
                    break;
                default:
                    Console.WriteLine("There is no such day of the week");
                    break;
            }

            Console.ReadKey();
        }
        static void Task16()
        {
            const int min_pay = 20;
            const int km_pay = 3;
            const int min_km = 5;
            const int delay_pay = 1;
            int km, delay_minutes;
            int result = min_pay;

            Console.WriteLine("Enter the number of kilometers:");

            try
            {
                km = int.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("Bad input!");
                Console.ReadKey();
                return;
            }

            Console.WriteLine("Enter the number of delay minutes:");

            try
            {
                delay_minutes = int.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("Bad input!");
                Console.ReadKey();
                return;
            }

            if ((km < 0) || (delay_minutes < 0))
            {
                Console.WriteLine("Bad input!");
                Console.ReadKey();
                return;
            }

            if (km > min_km)
                result += (km - min_km) * km_pay;

            result += delay_minutes * delay_pay;

            Console.WriteLine("Payment amount: {0}", result);
            Console.ReadKey();
        }
        static void Task17()
        {
            long num;
            Console.WriteLine("Enter a number:");

            try
            {
                num = int.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("Bad input!");
                Console.ReadKey();
                return;
            }

            if (num <= 1)
            {
                Console.WriteLine("{0} is not a prime number.", num);
                Console.ReadKey();
                return;
            }

            double sqrt = Math.Sqrt(num);

            for (long i = 2; i <= sqrt; i++)
            {
                if ((num % i) == 0)
                {
                    Console.WriteLine("{0} is not a prime number.", num);
                    Console.ReadKey();
                    return;
                }
            }

            Console.WriteLine("{0} is a prime number.", num);
            Console.ReadKey();
        }
        static void Task18()
        {
            int bet;
            int rnd_num;
            int result;

            Console.WriteLine("Enter a bet:");

            try
            {
                bet = int.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("Bad input!");
                Console.ReadKey();
                return;
            }

            if (bet <= 0)
            {
                Console.WriteLine("Bad input!");
                Console.ReadKey();
                return;
            }

            Random rnd = new Random();
            rnd_num = rnd.Next(1, 13);

#if DEBUG
            Console.WriteLine("Random result: {0}", rnd_num);
#endif
            
            if (rnd_num < 6)
                result = 0;
            else if (rnd_num < 9)
                result = bet;
            else if (rnd_num < 12)
                result = bet * 2;
            else
                result = bet * 10;

            Console.WriteLine("You win: {0}", result);
            Console.ReadKey();
        }
        static void Task19()
        {
            float amount;
            int menu;
            const float UAH_in_USD = 28;
            const float UAH_in_EUR = 30;

            Console.WriteLine("Enter the amount:");

            try
            {
                amount = float.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("Bad input!");
                Console.ReadKey();
                return;
            }

            Console.WriteLine("Choose a currency by entering a number:");
            Console.WriteLine("[0] UAH\n[1] USD\n[2] EUR");

            try
            {
                menu = int.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("Bad input!");
                Console.ReadKey();
                return;
            }

            switch (menu)
            {
                case 0:
                    Console.WriteLine("UAH: {0:.##}\nUSD: {1:.##}\nEUR: {2:.##}", amount, amount / UAH_in_USD, amount / UAH_in_EUR);
                    break;
                case 1:
                    Console.WriteLine("USD: {0:.##}\nUAH: {1:.##}\nEUR: {2:.##}", amount, amount * UAH_in_USD, amount * UAH_in_USD / UAH_in_EUR);
                    break;
                case 2:
                    Console.WriteLine("EUR: {0:.##}\nUSD: {1:.##}\nUAH: {2:.##}", amount, amount * UAH_in_EUR / UAH_in_USD, amount * UAH_in_EUR);
                    break;
                default:
                    Console.WriteLine("Bad input!");
                    Console.ReadKey();
                    return;
            }

            Console.ReadKey();
        }
        static void Task21()
        {
            int N;

            Console.WriteLine("Enter a number N:");

            try
            {
                N = int.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("Bad input!");
                Console.ReadKey();
                return;
            }

            for (int i = 1; i < 11; i++)
                Console.WriteLine("{0} x {1} = {2}\t {3} x {1} = {4}", i, N, i * N, i + 10, (i + 10) * N);

            Console.ReadKey();
        }
        static void Task22()
        {
            Console.WriteLine("Enter a number:");
            string str = Console.ReadLine();
            bool dot = false;
            int result;

            for (int i = 0; i < str.Length; i++)
            {
                if ((!char.IsDigit(str[i])) && (str[i] != '.'))
                {
                    Console.WriteLine("Bad input!");
                    Console.ReadKey();
                    return;
                }

                if (str[i] == '.')
                {
                    if (dot)
                    {
                        Console.WriteLine("Bad input!");
                        Console.ReadKey();
                        return;
                    }
                    else
                        dot = true;
                }
            }

            result = str.Length;
            if (dot)
                result--;

            Console.WriteLine("The number of digits is: {0}.", result);
            Console.ReadKey();
        }
        static void Task23()
        {
            int user_num;
            int rnd_num;

            Console.WriteLine("Enter a number from 1 to 146:");

            Random rnd = new Random();
            rnd_num = rnd.Next(1, 147);

            do
            {
                try
                {
                    user_num = int.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("Bad input!");
                    Console.ReadKey();
                    return;
                }

                if (user_num < rnd_num)
                    Console.WriteLine("Try a greater number:");
                else if (user_num > rnd_num)
                    Console.WriteLine("Try a smaller number:");
            }
            while (user_num != rnd_num);

            Console.WriteLine("Congratulations! You guessed it!");
            Console.ReadKey();           
        }
        static void Task24()
        {
            int N;
            Console.WriteLine("Enter a number N:");

            try
            {
                N = int.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("Bad input!");
                Console.ReadKey();
                return;
            }

            long sqr = 1;

            for (int i = 1; sqr < N; i++, sqr = i*i)
                Console.WriteLine(sqr);

            Console.ReadKey();
        }
        static void Task25()
        {
            const int number = 5;
            int sum = 0;
            float result;

            for (int i = 0; i < number; i++)
            {
                Console.WriteLine("Enter number #{0}:", i + 1);

                try
                {
                    sum += int.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("Bad input!");
                    Console.ReadKey();
                    return;
                }
            }

            result = (float)sum / number;
            Console.WriteLine("Average: {0}", result);
            Console.ReadKey();
        }
        static void Task26()
        {
            const int number = 5;
            long sum = 0;
            double result;
            Random rnd = new Random();

            for (int i = 0; i < number; i++)
            {
                int temp = rnd.Next();
                Console.WriteLine("Number #{0}: {1}", i + 1, temp);
                sum += temp;
            }

            result = sum / (double)number;
            Console.WriteLine("Average: {0}", result);
            Console.ReadKey();
        }
        static void Task27()
        {
            const int legs = 64;
            int rabbits = legs / 4;
            int geese = 0;
            int count = 1;

            do
            {
                Console.WriteLine("{0}. rabbits: {1}, geese: {2}", count, rabbits, geese);
                rabbits--;
                geese += 2;
                count++;
            }
            while (rabbits >= 0);

            Console.ReadKey();
        }
        static void Task28()
        {
            string good_pass = "root";
            string user_pass;

            Console.WriteLine("Enter a password:");

            do
            {
                user_pass = Console.ReadLine();

                if (user_pass != good_pass)
                    Console.WriteLine("Wrong password.");
            }
            while (user_pass != good_pass);

            int temp = 0;
            int space;
            while (temp < 38)
            {
                Console.Clear();

                for (int i = 0; i < temp; i++)
                    Console.Write(" ");

                Console.Write("->");

                space = 76 - temp * 2;

                for (int i = 0; i < space; i++)
                    Console.Write(" ");

                Console.Write("<-");

                temp++;
                Thread.Sleep(70);
            }

            string str = "Congratulation !";
            temp = 0;

            space = 40 - str.Length/2;
            while (temp < space)
            {
                Console.Clear();

                for (int i = 0; i < space - temp - 1; i++)
                    Console.Write(" ");

                Console.Write("<");

                for (int i = 0; i < temp; i++)
                    Console.Write(" ");

                Console.Write(str);

                for (int i = 0; i < temp; i++)
                    Console.Write(" ");

                Console.Write(">");

                temp++;
                Thread.Sleep(70);
            }

            Console.ReadKey();
        }

        static void ShowMenu()
        {
            Console.WriteLine("[11] The greatest number\t[21] Multiplication table");
            Console.WriteLine("[12] Mew and bark\t\t[22] The number of digits");
            Console.WriteLine("[13] Month\t\t\t[23] Guess the number");
            Console.WriteLine("[14] Good or bad\t\t[24] Squares");
            Console.WriteLine("[15] The day of a week\t\t[25] The average");
            Console.WriteLine("[16] Taxi\t\t\t[26] The average of random numbers");
            Console.WriteLine("[17] The prime number\t\t[27] Geese and rabbits");
            Console.WriteLine("[18] Lottery\t\t\t[28] Password");
            Console.WriteLine("[19] Currency");
            Console.WriteLine("\n[0] Exit\n");
        }
        static bool ExecuteMethod(int menu)
        {
            switch (menu)
            {
                case 11:
                    Task11();
                    break;
                case 12:
                    Task12();
                    break;
                case 13:
                    Task13();
                    break;
                case 14:
                    Task14();
                    break;
                case 15:
                    Task15();
                    break;
                case 16:
                    Task16();
                    break;
                case 17:
                    Task17();
                    break;
                case 18:
                    Task18();
                    break;
                case 19:
                    Task19();
                    break;
                case 21:
                    Task21();
                    break;
                case 22:
                    Task22();
                    break;
                case 23:
                    Task23();
                    break;
                case 24:
                    Task24();
                    break;
                case 25:
                    Task25();
                    break;
                case 26:
                    Task26();
                    break;
                case 27:
                    Task27();
                    break;
                case 28:
                    Task28();
                    break;
                case 0:
                    break;
                default:
                    return false;
            }
            return true;
        }

        static void Main(string[] args)
        {
            int menu = -1;
            bool wrong_input = false;


            while (menu != 0)
            {
                Console.Clear();
                ShowMenu();

                if (wrong_input)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Wrong input! Try again.\n");
                    Console.ResetColor();
                    wrong_input = false;
                }

                Console.WriteLine("Enter a number of the exersize:");

                try
                {
                    menu = int.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    wrong_input = true;
                    continue;
                }

                Console.Clear();

                if (!ExecuteMethod(menu))
                    wrong_input = true;
            }
        }
    }
}
