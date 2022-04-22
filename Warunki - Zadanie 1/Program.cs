using System;
namespace RokPrzestępny
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wprowadź rok: ");
            int Rok = int.Parse(Console.ReadLine());
            if (((Rok % 4 == 0) && (Rok % 100 != 0)) || (Rok % 400 == 0)) 
                Console.WriteLine("{0} jest rokiem przestępnym", Rok);
            else 
                Console.WriteLine("{0} nie jest rokiem przestępnym", Rok);
        }
    }
}