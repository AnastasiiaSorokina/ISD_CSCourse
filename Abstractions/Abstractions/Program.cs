using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstractions
{
    class Program
    {
        static void HandlerTask()
        {
            AbstractHandler XML = new XMLHandler();
            AbstractHandler TXT = new TXTHandler();
            AbstractHandler DOC = new DOCHandler();
            XML.Open();
            XML.Create();
            XML.Change();
            XML.Save();
            TXT.Open();
            TXT.Create();
            TXT.Change();
            TXT.Save();
            DOC.Open();
            DOC.Create();
            DOC.Change();
            DOC.Save();
            //too simple. smth wrong?..

            Console.ReadKey();
        }
        static void PlayerTask()
        {
            IPlayable player = new Player();
            player.Play();
            player.Pause();
            player.Stop();
            IRecordable recorder = new Player();
            recorder.Record();
            recorder.Pause();
            recorder.Stop();

            Console.ReadKey();
        }
        static int ReadInt()
        {
            bool input = true;
            int Result = 0;
            while (input)
            {
                string str = Console.ReadLine();
                try
                {
                    Result = int.Parse(str);
                    input = false;
                }
                catch
                {
                    Console.WriteLine("Error. Try again:");
                }
            }
            return Result;
        }
        static void Main(string[] args)
        {
            int Menu = -1;
            while (Menu != 0)
            {
                Console.Clear();
                Console.WriteLine("What to run?");
                Console.WriteLine("[1] Handler");
                Console.WriteLine("[2] Player");
                Console.WriteLine("\n[0] Exit");

                Menu = ReadInt();

                switch (Menu)
                {
                    case 1:
                        HandlerTask();
                        break;
                    case 2:
                        PlayerTask();
                        break;
                    case 0:
                        break;
                    default:
                        Console.WriteLine("Error! Press any key and try again.");
                        Console.ReadKey();
                        break;
                }
            }
        }
    }
}
