using System;

class MainClass {
   static void Main()  {
    Console.WriteLine ("Är det fint väder?:");
    int klar = 0;
    while (klar == 0) {
    string svar = Console.ReadLine();
    if (svar == "ja" ||  svar == "Ja") {
      Console.WriteLine("Vi går på picknick!");
      klar = 1;
    }
    else if (svar == "nej" || svar == "Nej") {
      Console.WriteLine("Vi Stannar inne och läser en bok");
      klar = 1;
    }
    else
      Console.WriteLine ("Jag förstår inte,Försök igen:");
    }
  }
}
