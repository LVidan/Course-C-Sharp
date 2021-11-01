using System;

namespace lecture_3_task_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int id = 0;
            bool josKandidata;

            do
            {
                string ime;
                int godiste;
                int godine;
                string pol;
                string polKandidataProvera;

                id++;

                // ime kandidata
                Console.WriteLine("Unesi ime kandidata?");
                ime = Console.ReadLine();

                // godiste kandidata
                Console.WriteLine("Unesi godiste kanidata?");
                godiste = Int32.Parse(Console.ReadLine());
                godine = DateTime.Today.Year - godiste;

                // pol kandidata
                Console.WriteLine("Unesi pol kanidata? Muski / Zenski");
                pol = Console.ReadLine();

                if (pol.ToLower().Trim() == "muski")
                {
                    polKandidataProvera = "Kandidat";
                }
                else
                {
                    polKandidataProvera = "Kandidatkinja";
                }

                Console.WriteLine($"{polKandidataProvera} pod rednim brojem {id}: {ime} ima {godine} god.");
                Console.WriteLine("----------------------");

                Console.WriteLine("Da li zelite da unesete novog kandidata? Da / Ne");
                josKandidata = (Console.ReadLine().ToLower().Trim() == "da");


            } while (josKandidata);

            Console.WriteLine("### PREKID PROGRAMA ###");
        }
    }
}
