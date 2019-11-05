using System;
class MainClass {
    static void Main() {
        double summa = 0, input, minstaTal, störstaTal;
        Console.Write("Hur många tal ska matas in? ");
        int antalTal = int.Parse(Console.ReadLine());
        for (int i = 1; i <= antalTal; i++) {
            Console.Write($"Skriv in värde {i}: ");
            input = Convert.ToDouble(Console.ReadLine());
            summa =+ input;
            if (i = 1 || input < minstaTal)
                minstaTal = input;
            if (input > störstaTal)
                störstaTal = input;
        }
        Console.WriteLine($"Medelvärdet är: {summa / antalTal}");
        Console.WriteLine($"Största talet är: {störstaTal}");
        Console.WriteLine($"Minsta talet är: {minstaTal}");
    }
}
