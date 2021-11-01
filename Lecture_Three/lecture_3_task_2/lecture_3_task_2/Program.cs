using System;

namespace lecture_3_task_2
{
    internal class Program
    {
        static void Ispis(int X, int Y, int Z)
        {
            Console.WriteLine("=== ISPISIVANJE ===");
            for (int i = X + 1; i < Y; i++)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("--------------------");

            for (int j = Z - 1; j > Y; j--)
            {
                Console.WriteLine(j);
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Upisati vrednosti za A, B i C tako da A ima najmanju vrednost, B da ima srednju i C najvecu");
            Console.WriteLine("---------------------");

            // A
            Console.WriteLine("Vrednost A:");
            int A = Int32.Parse(Console.ReadLine());

            // B
            Console.WriteLine("Vrednost B:");
            int B = Int32.Parse(Console.ReadLine());

            // C
            Console.WriteLine("Vrednost B:");
            int C = Int32.Parse(Console.ReadLine());

            /* A = manje od B i C
             * B = veci od A ali mani od C
             * C = veci i od A i od B
            */
            if (A < B && A < C && B > A && B < C)
            {
                Ispis(A, B, C);
            }
            else
            {
                Console.WriteLine($"Greska! Vrednost A:{A} mora biti manja od B:{B} i C:{C}, vrednost B mora biti manja od C a veca od A, vrednost C mora biti veca i od A i od B");
            }
        }
    }
}
