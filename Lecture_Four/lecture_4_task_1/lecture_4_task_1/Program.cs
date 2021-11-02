using System;

namespace lecture_4_task_1
{
    internal class Program
    {
        static int UnosPodataka()
        {
            int tempSati, tempMinuti, tempSekunde;
            // uzimamo sate
            Console.WriteLine("Uneti zeljene SATE?");
            tempSati = Int32.Parse(Console.ReadLine());

            // uzimamo minute
            Console.WriteLine("Uneti zeljene MINUTE?");
            tempMinuti = Int32.Parse(Console.ReadLine());

            // uzimamo sekunde
            Console.WriteLine("Uneti zeljene SEKUNDE?");
            tempSekunde = Int32.Parse(Console.ReadLine());

            // konvertovanje sati / minuta / sekundi
            // SATI = sati * 3600 (sek)
            // MINUTI = minuti * 60 (sek)
            // SEKUNDE = sekunde
            // ukupno = SATI + MIN + SEK
            int tempUkupnoSekundi = (tempSati * 3600) + (tempMinuti * 60) + tempSekunde;

            return tempUkupnoSekundi;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("====== pocetak programa =====");
            int sati, minuti, sekunde;

            // 1. krug unosa sati / minuta / sekundi 
            int sekundeIzUnosa_1 = UnosPodataka();

            Console.WriteLine("------------------------------");

            // 2. krug unosa sati / minuta / sekundi 
            int sekundeIzUnosa_2 = UnosPodataka();

            Console.WriteLine("------------------------------");

            int ukupnoSekundi = sekundeIzUnosa_1 + sekundeIzUnosa_2;

            // iz sekundi izvuci ostale vrednosti
            sekunde = ukupnoSekundi % 60;
            minuti = (ukupnoSekundi / 60) % 60;
            sati = ukupnoSekundi / 3600;

            Console.WriteLine("------------------------------");
            Console.WriteLine($"Ukupno vreme: {sati}h, {minuti}min, {sekunde}sec");
        }
    }
}
