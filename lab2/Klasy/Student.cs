namespace Klasy;

public class Student
{
    private int[] Oceny = [];

    public string Imie { get; }
    public string Nazwisko { get; }

    public double SredniaOcen
    {
        get
        {
            if (Oceny.Length == 0)
            {
                return 0;
            }

            return Oceny.Average();
        }
    }

    public Student(string imie, string nazwisko)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(imie);
        ArgumentException.ThrowIfNullOrWhiteSpace(nazwisko);

        Imie = imie;
        Nazwisko = nazwisko;
    }

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