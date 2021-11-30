using System;
using System.Collections.Generic;

namespace Personalregister
{
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

                            break;

                        case 2:
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

    }
}
