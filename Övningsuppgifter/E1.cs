using System;

namespace E1
{
    class Program
    {
        static void Main()
        {
             Console.Write("Skriv ett tal: ");
            double tal1 = Convert.ToDouble(Console.ReadLine());
              Console.Write("Skriv ett annat tal: ");
            double tal2 = Convert.ToDouble(Console.ReadLine());
             Console.Write("Summan av talen: ");
             Console.WriteLine(tal1+tal2);
             Console.Write("Differens av talen: ");
             Console.WriteLine(tal1-tal2);
             Console.Write("Produkten av talen: ");
             Console.WriteLine(tal1*tal2);
             Console.Write("Kvoten av talen: ");
             Console.WriteLine(tal1/tal2);
        }
    }
}
