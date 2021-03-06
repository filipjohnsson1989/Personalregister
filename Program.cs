using System;
using System.Collections.Generic;

namespace Personalregister
{
    // 1. Programklassen ska vara så enkel som möjligt och alla uppgifter ska hanteras genom att skapa nya klasser.
    // 1. Här har jag en Employee klass och en Program klass.

    // 2. Program klassen har två methoder GetEmployees and PrintEmployeesList
    // 2. Employee klassen har två privat propert för namn och lön
    // 2. Employee klassen har två public propert för namn och lön som man bara kan läser deras värderingar

    // 3. Programmet är nedan

    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>();

            bool stopProgramm = false;
            int inputNumber;

            while (!stopProgramm)
            {
                Console.WriteLine("Vad vill du göra?");
                Console.WriteLine("1- Ta emot och lagra anställda.");
                Console.WriteLine("2- Skriva ut registret.");
                Console.WriteLine("3- Avsluta.");

                var stringInput = Console.ReadLine();
                if (int.TryParse(stringInput, out inputNumber))
                {
                    switch (inputNumber)
                    {
                        case 1:
                            employees.AddRange(GetEmployees());
                            break;

                        case 2:
                            PrintEmployeesList(employees);
                            break;

                        case 3:
                            stopProgramm = true;
                            break;

                        default:
                            break;
                    }
                }
            }
        }

        static List<Employee> GetEmployees()
        {
            List<Employee> result = new List<Employee>();

            var stringInput = String.Empty;
            bool stopReading;

            Console.WriteLine("Skriva in som \"Filip Johnsson,1700\" anars tomt att klara");
            do
            {
                string namn;
                int wage;

                stringInput = Console.ReadLine();
                string[] stringInputs = stringInput.Split(",");
                stopReading = String.IsNullOrEmpty(stringInput);

                if (!stopReading)
                {
                    if (stringInputs.Length != 2)
                        Console.WriteLine("Ogiltig data, försök igen!");
                    else
                    {
                        namn = stringInputs[0];
                        wage = int.Parse(stringInputs[1]);

                        Employee employee = new Employee(namn, wage);

                        result.Add(employee);
                    }
                }
            } while (!stopReading);

            return result;
        }

        static void PrintEmployeesList(List<Employee> employees)
        {
            foreach (var employee in employees)
            {
                Console.WriteLine($"Namn: {employee.Name} , Lön: {employee.Wage}");
            }

        }
    }
}
