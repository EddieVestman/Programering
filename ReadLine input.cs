using System;

class MainClass {
   static void Main()  
   {
    Console.Write("Skriv ett tal: ");
    string strNr = Console.ReadLine();
    int tal = int.Parse(strNr);//Parse=Bara nummer
    Console.Write("Nästa heltal är: ");
    Console.Write(tal + 1);
    
  }
}
