using System;
using System.Collections.Generic;


namespace Binary_Converter
{
    class Program
    {
        public static void To_Binary(int x)
        {
            // Put Binaries Digits in the array
            List<int> Digits = new List<int>();
            while(x != 0)       
            {
                Digits.Add(x % 2);
                x /= 2;
            }

            // Reverse
            Digits.Reverse();


            // Print All Array elements
            foreach(int digit in  Digits)
            {
                Console.Write(digit);
            }
        }




        static void Main()
        {
            // Main Loop
            while(true)
            {
                // Asking For Convert....
                Console.Write("Which number you want to convert ? : ");

                var nombre = Console.ReadLine();

                Console.WriteLine();

                // Try To Convert User Input into integer
                if (int.TryParse(nombre, out int x))
                {
                    // Converting...
                    Console.Write($"{x} >> "); To_Binary(x);

                    Console.WriteLine(); Console.WriteLine();


                    // Exit/Restart Loop....
                    while (true)
                    {
                        Console.Write("Exit Program ? [y/n] : ");

                        var request = Console.ReadLine();

                        if (request == "y".ToLower())
                        {
                            System.Environment.Exit(0);
                        }
                        else if (request == "n".ToLower())
                        {
                            Console.Clear();
                            break;
                        }
                        else
                        {
                            Console.Clear();

                            Console.WriteLine("ERROR >> Invalid Input !");

                            Thread.Sleep(2000);

                            Console.Clear();

                            continue;
                        }
                    }


                }
                else
                {
                    // If User Input Is Invalid....
                    Console.Clear();

                    Console.WriteLine("ERROR >> Failed To convert User Input !");
                    Thread.Sleep(2000);

                    Console.Clear();


                    continue;
                }
            }
        }

    }
}