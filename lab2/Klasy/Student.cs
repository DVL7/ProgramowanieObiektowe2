namespace Klasy;


public class Student
{
    /// <summary>
    /// Przechowuje oceny
    /// </summary>
    private int[] Oceny = [];

    public string Imie { get; }
    public string Nazwisko { get; }

    /// <summary>
    /// Konstruktor obsługuje wyjątki i przypisuje parametry wejściowe do zmiennych
    /// </summary>
    /// <param name="imie">Imie</param>
    /// <param name="nazwisko">Nazwisko</param>
    public Student(string imie, string nazwisko)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(imie);
        ArgumentException.ThrowIfNullOrWhiteSpace(nazwisko);

        Imie = imie;
        Nazwisko = nazwisko;
    }

    /// <summary>
    /// Wylicza średnią z ocen będących już w tabeli Oceny
    /// </summary>
    /// <returns>Wyliczoną średnia</returns>
    public double SredniaOcen()
    {
        if (Oceny.Length != 0)
        {
            int i = 0; 
            double srednia = 0;

            foreach(int ocena in Oceny)
            {
                srednia += ocena;
                i += 1;
            }

            return srednia/i;
        }
        else
        {
            return 0;  
        }
    }

    /// <summary>
    /// Dodaje ocene do tablicy wszystkich ocen
    /// </summary>
    /// <param name="ocena">Ocena</param>
    /// <exception cref="ArgumentOutOfRangeException">Ocena zawiera się w 1-6</exception>
    public void DodajOcene(int ocena)
    {
        if (ocena < 1 || ocena > 6)
        {
            throw new ArgumentOutOfRangeException(nameof(ocena), "Ocena musi być z zakresu 1-6.");
        }

        Array.Resize(ref Oceny, Oceny.Length + 1);
        Oceny[^1] = ocena;
    }
}