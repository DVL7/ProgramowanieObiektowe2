using SortowanieLiczb;

Sortowanie sort = new Sortowanie();
double liczba;

while(true)
{
    Console.Clear();

    sort.WyswietlTablice();
    Console.WriteLine("\nPodaj liczbę: ");

    while (!Double.TryParse(Console.ReadLine(), out liczba))
    {
        Console.Clear();
        sort.WyswietlTablice();

        Console.WriteLine("\nPodana wartość jest nieprawidłowa! Spróbuj jeszcze raz.");
        Console.WriteLine("Podaj liczbę: ");
    }

    sort.DodajDoListy(liczba);
    sort.Posortuj();
}