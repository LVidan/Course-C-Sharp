using System;

namespace lecture_2_task_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // broj A
            Console.WriteLine("UNESI BREDNOST A:");
            int a = Int32.Parse(Console.ReadLine());

            // broj B
            Console.WriteLine("UNESI BREDNOST B:");
            int b = Int32.Parse(Console.ReadLine());

            // broj C
            Console.WriteLine("UNESI BREDNOST C:");
            int c = Int32.Parse(Console.ReadLine());

            switch (a)
            {
                case 1:
                case 3:
                    Console.WriteLine("Vrednost A je 1 ili 3");
                    break;
                case 2:
                    b = c--;
                    Console.WriteLine($"{b} {c}");
                    break;
                default:
                    b = c == 4 ? 5 : 6;
                    break;
            }
            Console.WriteLine($"A = {a} / B = {b} / C = {c}");
        }
    }
}
