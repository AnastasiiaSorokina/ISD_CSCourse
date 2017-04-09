using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ADO
{
    class Program
    {
        static string InputString()
        {
            bool input = true;
            string str = "";
            while(input)
            {
                str = Console.ReadLine();
                if(str == "" || str == null)
                    Console.WriteLine("Input error! Try again:");
                else
                {
                    input = false;
                }
            }

            return str;
        }
        static int InputInt()
        {
            bool input = true;
            int number = 0;
            while(input)
            {
                string str = Console.ReadLine();
                try
                {
                    number = int.Parse(str);
                    input = false;
                }
                catch
                {
                    Console.WriteLine("Input error! Try again:");
                }

                if(number < 0)
                {
                    Console.WriteLine("Input error! Try again:");
                    input = true;
                }
            }

            return number;
        }
        static void AddToBase(SqlConnection conn)
        {
            Console.WriteLine("Enter a name:");
            string NewName = InputString();
            Console.WriteLine("Enter a surname:");
            string NewSurname = InputString();
            Console.WriteLine("Enter an age:");
            int NewAge = InputInt();
            string StringToAdd = String.Format("INSERT INTO [Student].[dbo].[User]([Name],[Surname],[Age]) VALUES ('{0}','{1}',{2})", NewName, NewSurname, NewAge);
            SqlCommand add = new SqlCommand(StringToAdd, conn);
            add.ExecuteNonQuery();
            add.Dispose();
            Console.WriteLine("Adding finished.\n");
        }
        static void OutputBase(SqlConnection conn)
        {
            SqlCommand output = new SqlCommand("Select * from [USER]", conn);
            SqlDataReader reader = output.ExecuteReader();
            Console.WriteLine("Name\tSurname\tAge");
            while(reader.Read())
            {
                string name = (string)reader["Name"];
                string surname = (string)reader["Surname"];
                int age = (int)reader["Age"];
                Console.WriteLine(name + "\t" + surname + "\t" + age);
            }
            reader.Close();
            reader.Dispose();
            output.Dispose();
            Console.WriteLine("\n");
        }
        static void Main(string[] args)
        {
            string connStr = "Data Source=(local);Initial Catalog=Student;User ID=sa;Password=sa";
            SqlConnection conn = new SqlConnection(connStr);
            try
            {
                conn.Open();
            }
            catch(Exception ex)
            {
                Console.WriteLine("Connection failed. Exception {0}", ex.ToString());
                Console.ReadKey();
                return;
            }

            int menu = -1;

            while(menu != 0)
            {
                Console.WriteLine("Choose a command:");
                Console.WriteLine("[1] Add an entry to the table.");
                Console.WriteLine("[2] Show the table.");
                Console.WriteLine("[0] Exit.");
                menu = InputInt();

                switch(menu)
                {
                    case 1:
                        AddToBase(conn);
                        break;
                    case 2:
                        OutputBase(conn);
                        break;
                    default:
                        if(menu != 0)
                            Console.WriteLine("Input error! Try again:");
                        break;
                }
            }

            conn.Close();
            conn.Dispose();
        }
    }
}
