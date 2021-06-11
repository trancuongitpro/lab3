using System;
using System.Runtime.CompilerServices;

namespace lab3
{
    public class Atom
    {
         public int Number { get; set; }
         string Symbol { get; set; }
         string FullName { get; set; }
         float Weight { get; set; }

        public bool Accept()
        {
            try
            {
                while (true)
                {
                    Console.Write("Enter atomic number: ");
                    int number;
                    if (int.TryParse(Console.ReadLine(), out number))
                    {
                        Number = number;
                        if (Number == 0)
                        {
                            return false;
                        }
                        break;
                    }
                }
                Console.Write("Enter symbol: ");
                Symbol = Console.ReadLine();
                Console.Write("Enter full name: ");
                FullName = Console.ReadLine();
                while (true)
                {
                    Console.WriteLine("Enter atomic weight: ");
                    if (float.TryParse(Console.ReadLine(), out var number))
                    {
                        Weight = number;
                        break;
                    }                 
                }

                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            return false;
        }

        public void Display()
        {
            Console.WriteLine($"{Number} {Symbol} {FullName} {Weight}");
        }
    }
}