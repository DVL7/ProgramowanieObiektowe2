using Tablica10;

double[] tab = new double[10];

for (int i = 0; i < tab.Length; i++)
{
    Console.WriteLine($"Podaj liczbę {i}");
    while (!Double.TryParse(Console.ReadLine(), out tab[i]))
    {
        Console.Clear();
        Console.WriteLine("Podana wartość jest nieprawidłowa! Spróbuj jeszcze raz.");
        Console.WriteLine($"Podaj liczbę {i}");

    }

}

Tablica tablica = new Tablica(tab);

Console.Clear();
tablica.WyswietlTablice();
Console.WriteLine("\n");

Console.WriteLine("Suma: " + tablica.Suma);
Console.WriteLine("Srednia: " + tablica.Srednia);
Console.WriteLine("Min: " + tablica.Min);
Console.WriteLine("Max: " + tablica.Max);

