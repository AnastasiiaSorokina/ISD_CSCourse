using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Employee
    {
        string surname;
        string name;
        string position;
        int experience;
        double salary;
        double TaxCharge;

        public Employee(string surname, string name)
        {
            this.surname = surname;
            this.name = name;
            this.position = "unknown";
            this.experience = 0;
            this.salary = 0;
            this.TaxCharge = 0;
        }
        public void Calculate(string position, int experience)
        {
            this.experience = experience;
            this.position = position;

            if (position == "guard")
            {
                this.salary = 100 * experience;
            }
            else if (position == "manager")
            {
                this.salary = 1000 * experience;
            }
            else if (position == "principal")
            {
                this.salary = 10000 * experience;
            }
            else
            {
                Console.WriteLine("Input error!");
                this.position = "unknown";
            }

            this.TaxCharge = salary * 0.1;
        }
        public void Output()
        {
            Console.WriteLine("----------------------");
            Console.WriteLine("Info about an employee");
            Console.WriteLine("----------------------");
            Console.WriteLine("Surname: {0}", surname);
            Console.WriteLine("Name: {0}", name);
            Console.WriteLine("Position: {0}", position);
            Console.WriteLine("Experience: {0}", experience);
            Console.WriteLine("Salary: {0}", salary);
            Console.WriteLine("Tax charge: {0}", TaxCharge);
        }
    }
}
