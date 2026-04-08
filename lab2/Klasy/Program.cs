using Klasy;


Console.WriteLine("\n");
Console.WriteLine("Osoba.cs\n");

Osoba osoba = new Osoba("Dawid", "Deryło", "23");
osoba.WyswietlInformacje();

Console.WriteLine("\n");
Console.WriteLine("BankAccount.cs\n");

BankAccount konto = new BankAccount("Jan Kowalski", 1000);
konto.Wplata(500);
konto.Wyplata(200);
Console.WriteLine($"Saldo: {konto.Saldo}");

