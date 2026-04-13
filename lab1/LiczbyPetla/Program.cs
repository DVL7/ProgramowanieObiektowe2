while (true)
{
    Console.WriteLine("Podaj liczbę całkowitą: ");

    int liczba;
    /// <summary>
    /// Walidacja ?int
    /// </summary>
    while (!int.TryParse(Console.ReadLine(), out liczba))
    {
        Console.Clear();
        Console.WriteLine("Błąd! Spróbuj jeszcze raz.");
        Console.WriteLine("Podaj liczbę całkowitą: ");
        continue;
    }
    /// <summary> 
    /// Warunek wyjścia 
    /// </summary>
    if (liczba < 0)
    {
        break;
    }

    Console.Clear();
    Console.WriteLine($"Wprowadzono liczbę: {liczba}");
}