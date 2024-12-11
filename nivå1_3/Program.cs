using System;
namespace nivå1_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int summa = 0;

            for (int i = 1; i <=5; i++)
            {
                Console.WriteLine("Skriv in heltal nummer "+i+":");
                int tal = int.Parse(Console.ReadLine());
                summa += tal;
            }
            Console.WriteLine("Summar av de talen blir: " + summa + ".");
        }
    }
}