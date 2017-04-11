using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class User
    {
        string login;
        string name;
        string surname;
        int age;
        DateTime date;

        public string Login
        {
            get
            {
                return login;
            }
            set
            {
                login = value;
            }
        }
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public string Surname
        {
            get
            {
                return surname;
            }
            set
            {
                surname = value;
            }
        }
        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                age = value;
            }
        }
        public User(string login, string name, string surname, int age)
        {
            Login = login;
            Name = name;
            Surname = surname;
            Age = age;
            date = DateTime.Now;
        }

        public void Output()
        {
            Console.WriteLine("-----------------");
            Console.WriteLine("Info about a user");
            Console.WriteLine("-----------------");
            Console.WriteLine("Login: {0}", Login);
            Console.WriteLine("Name: {0}", Name);
            Console.WriteLine("Surname: {0}", Surname);
            Console.WriteLine("Age: {0}", Age);
            Console.WriteLine("Date of signing in: {0}", date.ToShortDateString());
        }
    }
}
