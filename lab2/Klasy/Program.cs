using Klasy;

// Zadanie 1 
Console.WriteLine("\n");
Console.WriteLine("Osoba.cs\n");

Osoba osoba = new Osoba("Dawid", "Deryło", "23");
osoba.WyswietlInformacje();

// Zadanie 2
Console.WriteLine("\n");
Console.WriteLine("BankAccount.cs\n");

BankAccount konto = new BankAccount("Jan Kowalski", 1000);
konto.Wplata(500);
konto.Wyplata(200);
Console.WriteLine($"Saldo: {konto.Saldo}");

// Zadanie 3
Console.WriteLine("\n");
Console.WriteLine("Student.cs\n");

Student student = new Student("Dawid", "Deryło");
student.DodajOcene(2);
student.DodajOcene(3);
student.DodajOcene(4);
Console.WriteLine($"Srednia ocen: {student.SredniaOcen()}");

// Zadanie 4 
Console.WriteLine("\n");
Console.WriteLine("Licz.cs\n");

Licz licz = new Licz(100);
licz.Dodaj(50);
licz.Odejmij(25);
Console.WriteLine($"Liczba: {licz.Value}");