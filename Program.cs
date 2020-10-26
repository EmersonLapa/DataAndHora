using System;

namespace DataEHora
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Olá Digite uma Data: ");
            DateTime d1 = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Data Local: " + d1);
            Console.WriteLine("Data UTC: " + d1.ToUniversalTime());
            Console.WriteLine("Apenas a hora: " + d1.ToString("HH:mm:ss"));
        }
    }
}
