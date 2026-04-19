using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using ContactManagerSQL.Data;
using ContactManagerSQL.Models;
class Program
{
    // =========================
    // 1) CONNECTION STRING
    // =========================
    // TODO (student):
    // - Uzupełnij poprawny connection string do swojej instancji SQL Server
    // - Wskazówka: w SSMS sprawd ź nazw ę serwera (np. "." albo "DESKTOP - XYZ")
    // - Wskazówka: Database musi by ć ContactDB
    // Przykład:
    // "Server=.;Database=ContactDB;Trusted_Connection=True;Encrypt=False;";
    const string ConnectionString = "Server=Dawid;Database=ContactDB;Trusted_Connection=True;Encrypt=False;";
    static void Main()
    {
        // TODO (student):
        // - Utwórz obiekt repozytorium ContactRepository, przekazując ConnectionString
        // - Wskazówka: var repo = new ContactRepository(ConnectionString);
        var repo = new ContactRepository(ConnectionString); // <-- usu ń null! po poprawnym utworzeniu repo
        while(true)
        {
            PrintMenu();
            string choice = Console.ReadLine() ?? "" ;
            try
            {
                switch(choice)
                {
                case "1":
                    // TODO (student): wywołaj metod ę Create(repo)
                    Create(repo);
                    break;
                case "2":
                    // TODO (student): wywołaj metod ę ReadAll(repo)
                    ReadAll(repo);
                    break;
                case "3":
                    // TODO (student): wywołaj metod ę Search(repo)
                    Search(repo);
                    break;
                case "4":
                    // TODO (student): wywołaj metod ę Update(repo)
                    Update(repo);
                    break;
                case "5":
                    // TODO (student): wywołaj metod ę Delete(repo)
                    Delete(repo);
                    break;
                case "6":
                    // TODO (student): wywołaj metod ę BulkInsertDemo(repo)
                    BulkInsertDemo(repo);
                    break ;
                case "0":
                    return;
                default:
                Console.WriteLine( "Nieprawidłowy wybór." );
                break;
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine("Wystąpiłbłąd:" + ex.Message);
            }
        }
    }
    static void PrintMenu()
    {
        Console.WriteLine("\n=== CONTACT MANAGER (ADO.NET + DAL) ===");
        Console.WriteLine("1) Dodaj kontakt");
        Console.WriteLine("2) Pokaż wszystkie");
        Console.WriteLine("3) Wyszukaj po nazwisku");
        Console.WriteLine("4) Edytuj kontakt");
        Console.WriteLine("5) Usuń kontakt");
        Console.WriteLine("6) Bulkinsert (transakcja) - demo");
        Console.WriteLine("0) Wyjście");
        Console.Write("Wybór: ");
    }
    // =========================
    // CREATE
    // =========================
    static void Create(ContactRepository repo)
    {
        // TODO (student):
        // - Utwórz obiekt Contact i pobierz dane od użytkownika
        // - Użyj ReadRequired(...) dla imienia i nazwiska
        // - Użyj ReadOptional(...) dla telefonu i email
        // - Wywołaj repo.Add(contact) i wyświetl Id nowego rekordu
        // Wskaz ówka:
        // var c = new Contact { FirstName = ..., LastName = ..., Phone = ..., Email = ... };
        // int id = repo.Add(c);

        var c = new Contact
        {
            FirstName = ReadRequired("Imię: "),
            LastName = ReadRequired("Nazwisko: "),
            Phone = ReadOptional("Telefon (opcjonalnie): "),
            Email = ReadOptional("Email (opcjonalnie): ")
        };

        int id = repo.Add(c);
        Console.WriteLine($"Dodano kontakt o ID = {id}");
    }
    // =========================
    // READ
    // =========================
    static void ReadAll(ContactRepository repo)
    {
        // TODO (student):
        // - Pobierz list ę: repo.GetAll()
        // - Wy ś wietl nag łó wek tabeli
        // - Przejdź po liście i wypisz kontakty (możesz użyć ToString() z modelu Contact)
        var contacts = repo.GetAll();
        if (contacts.Count == 0)
        {
            Console.WriteLine("Brak kontaktów.");
            return;
        }

        Console.WriteLine("Id | Imię | Nazwisko | Telefon | Email");
        foreach (var c in contacts)
        {
            Console.WriteLine(c);
        }
    }
    // =========================
    // SEARCH BY LAST NAME
    // =========================
    static void Search(ContactRepository repo)
    {
        // TODO (student):
        // - Pobierz od użytkownika fragment nazwiska
        // - Wywołaj repo.SearchByLastName(fragment)
        // - Wyświetl wyniki
        string fragment = ReadRequired("Fragment nazwiska: ");
        var results = repo.SearchByLastName(fragment);

        if (results.Count == 0)
        {
            Console.WriteLine("Brak wyników.");
            return;
        }

        foreach (var c in results)
        {
            Console.WriteLine(c);
        }
    }
    // =========================
    // UPDATE
    // =========================
    static void Update(ContactRepository repo)
    {
        // TODO (student):
        // - Pobierz ID (ReadInt)
        // - Pobierz nowe dane (ReadRequired/ReadOptional)
        // - Utwórz Contact z Id i polami
        // - Wywołaj repo.Update(contact)
        // - Wyświetl komunikat czy zaktualizowano
        int id = ReadInt("Id kontaktu do edycji: ");
        var c = new Contact
        {
            Id = id,
            FirstName = ReadRequired("Nowe imię: "),
            LastName = ReadRequired("Nowe nazwisko: "),
            Phone = ReadOptional("Nowy telefon (opcjonalnie): "),
            Email = ReadOptional("Nowy email (opcjonalnie): ")
        };

        bool ok = repo.Update(c);
        Console.WriteLine(ok ? "Zaktualizowano kontakt." : "Nie znaleziono kontaktu.");
    }
    // =========================
    // DELETE
    // =========================
    static void Delete(ContactRepository repo)
    {
        // TODO (student):
        // - Pobierz ID (ReadInt)
        // - Wywołaj repo.Delete(id)
        // - Wyświetl komunikat czy usuni ęto
        int id = ReadInt("Id kontaktu do usunięcia: ");
        bool ok = repo.Delete(id);
        Console.WriteLine(ok ? "Usunięto kontakt." : "Nie znaleziono kontaktu.");
    }
    // =========================
    // TRANSACTION (BULK INSERT)
    // =========================
    static void BulkInsertDemo(ContactRepository repo)
    {
        // TODO (student) – wersja podstawowa:
        // - Utwórz list ę kilku Contact (np. 3 rekordy)
        // - Wywołaj repo.BulkInsert(lista)
        // - Wyświetl ile dodano
        // TODO (student) – wersja na 5.0 (opcjonalnie):
        // - Zapytaj użytkownika ile rekordów wygenerować
        // - Wygeneruj przykładowe dane w pętli
        var contacts = new List<Contact>
        {
            new Contact { FirstName = "Jan", LastName = "Kowalski", Phone = "500100200", Email = "jan@example.com" },
            new Contact { FirstName = "Anna", LastName = "Nowak", Phone = "500200300", Email = "anna@example.com" },
            new Contact { FirstName = "Piotr", LastName = "Zieliński", Phone = null, Email = "piotr@example.com" }
        };

        int inserted = repo.BulkInsert(contacts);
        Console.WriteLine($"Dodano rekordów: {inserted}");
    }
    // ==========================================================
    // HELPERS
    // ==========================================================
    static string ReadRequired( string label)
    {
        while(true)
        {
            Console.Write(label);
            string s = Console .ReadLine() ?? "";
            if (!string.IsNullOrWhiteSpace(s)) return s.Trim();
            Console.WriteLine("Pole nie może być puste.");
        }
    }
    static string ? ReadOptional(string label)
    {
        Console.Write(label);
        string s = Console.ReadLine() ?? "";
        s = s.Trim();
        return string.IsNullOrWhiteSpace(s) ? null : s;
    }
    static int ReadInt(string label)
    {
        while(true)
        {
            Console.Write(label);
            if (int.TryParse(Console.ReadLine(), out int id)) return id;
            Console.WriteLine("Podaj poprawn ą liczb ę ca ł kowit ą.");
        }
    }
}