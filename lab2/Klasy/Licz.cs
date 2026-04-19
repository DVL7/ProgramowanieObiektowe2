namespace Klasy;

public class Licz
{
    /// <summary>
    /// Przechowuje liczbę 
    /// </summary>
    public double Value;
    /// <summary>
    /// Konstruktor przypisuje parametr wejściowy do zmiennej
    /// </summary>
    /// <param name="value">liczba początkowa</param>
    public Licz(double value)
    {
        Value = value;
    }
    
    /// <summary>
    /// Dodaje liczbę do zmiennej 
    /// </summary>
    /// <param name="number">dodawana liczba</param>
    public void Dodaj(double number)
    {
        Value += number;
    }

    /// <summary>
    /// Odejmuje liczbę od zmiennej 
    /// </summary>
    /// <param name="number">Odejmowana liczba</param>
    public void Odejmij(double number)
    {
        Value -= number;
    }
}