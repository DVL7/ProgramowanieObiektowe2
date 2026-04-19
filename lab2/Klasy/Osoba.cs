namespace Klasy;


public class Osoba
{
    /// <summary>
    /// Składa się z dwóch znaków.
    /// </summary>
    string Imie;
    /// <summary>
    /// Składa się z dwóch znaków.
    /// </summary>
    string Nazwisko;
    /// <summary>
    /// Liczba dodatnia.
    /// </summary>
    int Wiek;

    /// <summary>
    /// Konstruktor przyjmuje 3 argumenty oraz sprawdza czy są zgodne z założeniami. Konwertuje przyjwoną zmienną wiek na int.
    /// </summary>
    /// <param name="imie">imie osoby, niewalidowany string.</param>
    /// <param name="nazwisko">nazwisko osoby, niewalidowany string.</param>
    /// <param name="wiek">wiek osoby, niewalidowany string.</param>
    /// <exception cref="ArgumentException">Występuje gdy dane nie spełaniają założeń zmiennych klasy.</exception>
    public Osoba(string imie, string nazwisko, string wiek)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(imie);
        ArgumentException.ThrowIfNullOrWhiteSpace(nazwisko);

        this.Imie = imie;
        this.Nazwisko = nazwisko;

        if (!int.TryParse(wiek, out Wiek))
        {
            throw new ArgumentException("Wiek musi być liczbą dodatnią.", nameof(wiek));
        }
/* 
        if (string.IsNullOrEmpty(imie))
        {
            throw new ArgumentException("Imie jest wymagane.", nameof(imie));
        }
        if (string.IsNullOrEmpty(nazwisko))
        {
            throw new ArgumentException("Nazwisko jest wymagane.", nameof(nazwisko));
        }
*/

        if (Wiek <= 0)
        {
            throw new ArgumentException("Wiek musi być liczbą dodatnią.", nameof(Wiek));
        }

        if (Imie.Length < 2)
        {
            throw new ArgumentException("Imie musi się składać z przynajmniej dwóch liter.", nameof(Imie));
        }
        if (Nazwisko.Length < 2)
        {
            throw new ArgumentException("Nazwisko musi się składać z przynajmniej dwóch liter.", nameof(Nazwisko));
        }
    }

    /// <summary>
    /// Wyswietla dane osoby.
    /// </summary>
    public void WyswietlInformacje()
    {
        Console.WriteLine($"Imie: {Imie}");
        Console.WriteLine($"Nazwisko: {Nazwisko}");
        Console.WriteLine($"Wiek: {Wiek}");
    }
}