using System;

namespace lecture_5_task_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i, j, brKolona, brRedova;

            /* dinamicki unos
            * 1. br kolona
            * 2. br redova
            */
            Console.WriteLine("Uneti zeljeni broj kolona?");
            brKolona = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Uneti zeljeni broj redova?");
            brRedova = Int32.Parse(Console.ReadLine());

            // provera da korisnik ne unese PARAN broj za broj kolona
            if (brKolona % 2 == 0)
            {
                Console.WriteLine("Doslo je do greske. Unesite paran broj kolona!!!");
            }
            else
            {
                for (i = 1; i <= brKolona; i++)
                {
                    for (j = 1; j <= brRedova; j++)
                    {
                        if (i % 2 == 0 && j > 1 && j < brRedova)
                        {
                            Console.Write(" ");
                        }
                        else
                        {
                            Console.Write('*');
                        }
                    }

                    Console.WriteLine();
                }
            }
        }
    }
}
