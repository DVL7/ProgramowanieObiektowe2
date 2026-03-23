using Tablica10;

// Inicjalizacja tablicy, w której przechowamy 10 wprowadzonych przez użytkownika liczb.
double[] tab = new double[10];

// Lista tekstowa wspomagająca wyświetlanie już pobranych liczb z tablicy.
List<String> StrArray = new List<string>();

// Pętla pobierająca 10 liczb zmiennoprzecinkowych od użytkownika.
for (int i = 0; i < tab.Length; i++)
{
    // Jeśli pobraliśmy już chociaż jedną liczbę, wyświetl podsumowanie wprowadzonych liczb.
    if(i > 0) { Console.WriteLine(string.Join("", StrArray)); }

    Console.WriteLine($"\nPodaj liczbę {i}");

    // Zabezpieczenie na wypadek wpisania błędnego ciągu znaków (np. liter zamiast cyfr).
    while (!Double.TryParse(Console.ReadLine(), out tab[i]))
    {
        Console.Clear();
        Console.WriteLine("Podana wartość jest nieprawidłowa! Spróbuj jeszcze raz.");
        Console.WriteLine($"Podaj liczbę {i}");
    }

    // Dodanie poprawnie sparsowanej wartości do listy tekstowej ze sformatowanym nawiasem.
    StrArray.Add("["+tab[i].ToString() + "]");

    // Czyszczenie konsoli przed następną iteracją zapytania.
    Console.Clear();
}

// Utworzenie obiektu naszej klasy na podstawie wypełnionej tablicy.
// Konstruktor klasy od razu wykonuje wszystkie stosowne obliczenia (Suma, Min, Max itp.).
Tablica tablica = new Tablica(tab);

// Czyszczenie konsoli i prezentacja wyników działania klasy.
Console.Clear();
tablica.WyswietlTablice();
Console.WriteLine("\n");

// Wypisanie zwróconych wyliczeń z przygotowanych właściwości w klasie Tablica.
Console.WriteLine("Suma: " + tablica.Suma);
Console.WriteLine("Srednia: " + tablica.Srednia);
Console.WriteLine("Iloczyn: " + tablica.Iloczyn);
Console.WriteLine("Min: " + tablica.Min);
Console.WriteLine("Max: " + tablica.Max);

