using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Program
    {
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
        static void PrinterTask()
        {
            Printer printer = new DerivedPrinter();
            printer.Print("The text from the derived class.");
            Printer printer2 = new Printer();
            printer2.Print("The text from the base class.");
            Console.ReadKey();
        }
        static void ClassRoomTask()
        {
            Pupil pupil1 = new ExcelentPupil();
            Pupil pupil2 = new GoodPupil();
            Pupil pupil3 = new BadPupil();
            ClassRoom classRoom = new ClassRoom(pupil1, pupil2, pupil3);
            int NumberOfPupil = 1;
            foreach (Pupil pupil in classRoom.Pupils)
            {
                Console.WriteLine("Pupil #{0}", NumberOfPupil);
                NumberOfPupil++;
                pupil.Study();
                pupil.Read();
                pupil.Write();
                pupil.Relax();
            }
            Console.ReadKey();
        }
        static void VehicleTask()
        {
            Console.WriteLine("Lets's create a car");
            Vehicle car = new Car();
            Console.WriteLine("Lets's create a plane");
            Vehicle plane = new Plane();
            Console.WriteLine("Lets's create a ship");
            Vehicle ship = new Ship();
            car.ShowInfo();
            plane.ShowInfo();
            ship.ShowInfo();
            Console.ReadKey();
        }
        static void DocumentWorkerTask()
        {
            Console.WriteLine("To work with the Document Worker, please enter your key:");
            DocumentWorker docWorker;
            string str = Console.ReadLine();

            if (str == "1")     //so difficult to guess :)
            {
                docWorker = new ProDocumentWorker();
            }
            else if (str == "2")
            {
                docWorker = new ExpertDocumentWorker();
            }
            else
            {
                docWorker = new DocumentWorker();
            }

            int menu = -1;
            while (menu != 0)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("What to do?");
                Console.WriteLine("[1] Open document.");
                Console.WriteLine("[2] Edit document.");
                Console.WriteLine("[3] Save document.");
                Console.WriteLine("\n[0] Exit");
                Console.ResetColor();

                menu = ReadInt();

                switch (menu)
                {
                    case 1:
                        docWorker.OpenDocument();
                        break;
                    case 2:
                        docWorker.EditDocument();
                        break;
                    case 3:
                        docWorker.SaveDocument();
                        break;
                    case 0:
                        break;
                    default:
                        Console.WriteLine("Error! Try again:");
                        break;
                }
            }
        }
        static void Main(string[] args)
        {
            int Menu = -1;
            while (Menu != 0)
            {
                Console.Clear();
                Console.WriteLine("What to run?");
                Console.WriteLine("[1] Printer\t[3] Vehicle");
                Console.WriteLine("[2] ClassRoom\t[4] Document Worker");
                Console.WriteLine("\n[0] Exit");

                Menu = ReadInt();

                switch (Menu)
                {
                    case 1:
                        PrinterTask();
                        break;
                    case 2:
                        ClassRoomTask();
                        break;
                    case 3:
                        VehicleTask();
                        break;
                    case 4:
                        DocumentWorkerTask();
                        break;
                    case 0:
                        break;
                    default:
                        Console.WriteLine("Error! Try again:");
                        break;
                }                
            }
        }
    }
}
