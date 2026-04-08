using Klasy;

Console.WriteLine($"Podaj imie: ");
string? imie = Console.ReadLine();

Console.WriteLine($"Podaj nazwisko: ");
string? nazwisko = Console.ReadLine();

Console.WriteLine($"Podaj wiek: ");
string? wiek = Console.ReadLine();

Osoba osoba = new Osoba(imie, nazwisko, wiek);

Console.WriteLine("\n\n");
osoba.WyswietlInformacje();