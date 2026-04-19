namespace Klasy;

public class Sumator
{
    private double[] Liczby = [1,2,3,4,5,6,7,8,9,10]; 

    public Sumator()
    {
        
    }

    /// <summary>
    /// Oblicza sumę liczb z tablicy 
    /// </summary>
    /// <returns>Suma liczb z tablicy</returns>
    public double Suma()
    {
        double suma = 0;

        foreach(double liczba in Liczby)
        {
            suma += liczba;
        }

        return suma;
    }
    /// <summary>
    ///  Oblicza sumę liczb z tablicy podzielnych przez 2.
    /// </summary>
    /// <returns>Suma liczb podzielnych przez 2</returns>
    public double LiczbyPodziel2()
    {
        double suma = 0;

        foreach(double liczba in Liczby)
        {
            if(liczba % 2 == 0)
            {
                suma += liczba;
            }
        }

        return suma;
    }

    /// <summary>
    /// Oblicza ilosc liczb w tablict
    /// </summary>
    /// <returns>Ilosc liczb w tablicy</returns>
    public int IleElementow()
    {
        int liczbaElementow = 0;

        foreach(double liczba in Liczby)
        {
            liczbaElementow += 1;
        }

        return liczbaElementow;
    }

    /// <summary>
    /// Tworzy stringa z elementami tablicy
    /// </summary>
    /// <returns>Zwraca elementy tablicy w stringu do wyswietlenia</returns>
    public void WypiszElementy()
    {
        string elementy = "";

        foreach(double liczba in Liczby)
        {
            elementy += $"[{liczba}]";
        }

        Console.WriteLine(elementy);
    }

    /// <summary>
    ///  Tablicę liczb z tablicy elementow w danym przedziale.
    /// </summary>
    /// <param name="low">dolny przedzial</param>
    /// <param name="high">gorny przedzial</param>
    /// <returns>zwraca tablice liczb w danym przedziale</returns>
    public void OdDo(double low, double high)
    {
        string elementy = "";

        foreach(double liczba in Liczby)
        {
            if (liczba >= low && liczba <= high)
            {
                elementy += $"[{liczba}]";
            }
        }

        Console.WriteLine(elementy);
    }
}