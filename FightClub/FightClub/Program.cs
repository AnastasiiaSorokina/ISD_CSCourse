using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FightClub
{
    class Program
    {
        static int Choose(Fighter target, ref int count, ConsoleColor color)
        {
            foreach (BodyPartType type in Enum.GetValues(typeof(BodyPartType)))
            {
                Console.WriteLine("[{0}] {1}", (int)type + 1, type.ToString());
                count++;
            }

            Console.ForegroundColor = color;
            Console.WriteLine("\nYour choice:");

            bool input = true;
            int number = -1;

            do
            {
                string str = Console.ReadLine();

                try
                {
                    number = int.Parse(str);
                    input = false;
                }
                catch (Exception)
                {
                    Console.WriteLine("Wrong input! Try again:");
                    continue;
                }

                if (number < 1 || number > count)
                {
                    Console.WriteLine("Wrong input! Try again:");
                    input = true;
                }

            } while (input);

            Console.ResetColor();
            return number - 1;
        }
        static int Randomizer(Fighter target, int count, ConsoleColor color)
        {
            Console.ForegroundColor = color;

            Random rnd = new Random();
            int number = rnd.Next(0, count);
            Console.WriteLine("He chose {0}\n", target.parts[number].name);

            Console.ResetColor();
            return number;
        }
        static void WhoWin(Fighter you, Fighter foe)
        {
            if (foe.HP == 0)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("You win!");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("You lose!");
            }

            Console.ResetColor();
        }

        static void Main(string[] args)
        {
            Fighter you = new Fighter();
            Fighter foe = new Fighter();

            while (you.HP > 0 && foe.HP > 0)
            {
                Console.WriteLine("Your HP: {0}\tHis HP: {1}\n", you.HP, foe.HP);

                Console.WriteLine("Where to hit?");

                int count = 0;
                int number = Choose(foe, ref count, ConsoleColor.Magenta);
                int number2 = Randomizer(foe, count, ConsoleColor.Magenta);

                foe.Block((BodyPartType)number2);
                you.Hit(foe, (BodyPartType)number);

                if (foe.HP == 0)
                    break;

                Console.WriteLine("Your HP: {0}\tHis HP: {1}\n", you.HP, foe.HP);

                Console.WriteLine("Where to block?");

                count = 0;
                number = Choose(you, ref count, ConsoleColor.Cyan);
                number2 = Randomizer(you, count, ConsoleColor.Cyan);

                you.Block((BodyPartType)number);
                foe.Hit(you, (BodyPartType)number2);
            }

            WhoWin(you, foe);
            Console.ReadKey();
        }
    }
}
