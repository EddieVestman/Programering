using System;

class MainClass {
   static void Main()  
   {
    Console.Write("Skriv tal 1: "); 
    string Nr1 = Console.ReadLine();
    int tal1 = int.Parse(Nr1);
    Console.Write("Skriv tal 2: "); 
    string Nr2 = Console.ReadLine();
    int tal2 = int.Parse(Nr2);
    Console.Write("Summan av talen är = ");
    Console.WriteLine(tal1+tal2);
    Console.Write("Differansen av talen är = ");
    Console.WriteLine(tal1-tal2);
    

    
  }
}
