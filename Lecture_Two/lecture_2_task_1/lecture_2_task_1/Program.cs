using System;

namespace cas2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("UPISI BROJ A:");
            int num_A = Int32.Parse(Console.ReadLine());

            Console.WriteLine("UPISI BROJ B:");
            int num_B = Int32.Parse(Console.ReadLine());

            if (num_A == num_B || num_B < num_A)
            {
                Console.WriteLine("POGRESAN UNOS");
            }
            else
            {
                // OVDE IDE ZADATAK
                for (int counter = num_A; counter <= num_B; counter++)
                {
                    if (counter % 14 == 0)
                    {
                        Console.WriteLine($"{counter} je deljiv sa 14");
                    }
                }
            }

        }
    }
}