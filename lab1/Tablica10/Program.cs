using Tablica10;

double[] tab = new double[10];
List<String> StrArray = new List<string>();

for (int i = 0; i < tab.Length; i++)
{
    if(i > 0) { Console.WriteLine(string.Join("", StrArray)); }


    Console.WriteLine($"\nPodaj liczbę {i}");
    while (!Double.TryParse(Console.ReadLine(), out tab[i]))
    {
        Console.Clear();
        Console.WriteLine("Podana wartość jest nieprawidłowa! Spróbuj jeszcze raz.");
        Console.WriteLine($"Podaj liczbę {i}");

    }

    StrArray.Add("["+tab[i].ToString() + "]");

    Console.Clear();

}

Tablica tablica = new Tablica(tab);

Console.Clear();
tablica.WyswietlTablice();
Console.WriteLine("\n");

Console.WriteLine("Suma: " + tablica.Suma);
Console.WriteLine("Srednia: " + tablica.Srednia);
Console.WriteLine("Iloczyn: " + tablica.Iloczyn);
Console.WriteLine("Min: " + tablica.Min);
Console.WriteLine("Max: " + tablica.Max);

