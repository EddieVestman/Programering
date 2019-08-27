using System;

class MainClass {
   static void Main()  
   {
    Console.Write("Skriv ett tal: ");
    int tal = int.Parse(Console.ReadLine());
    if (tal > 10)
    Console.WriteLine("Talet är större än tio");
    else if (tal < 10)
    Console.WriteLine("Talet är mindre än tio");
    else if (tal == 10)
    Console.WriteLine ("Talet är = 10");
    

    
  }
}
