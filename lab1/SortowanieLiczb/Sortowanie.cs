using System;

namespace SortowanieLiczb;
/// <summary>
/// Klasa służy do sortowania liczb metodą bąbelkową
/// </summary>
public class Sortowanie
{
    /// <summary>
    /// Przechowuje liczby przed i po sortowaniu
    /// </summary>
   private List<double> NumArray = new List<double>();


    public Sortowanie()
    {
        
    }

    /// <summary>
    /// Dodaje liczbę do Listy
    /// </summary>
    /// <param name="liczba">Liczba dodawana do listy</param>
    public void DodajDoListy(double liczba)
    {
        NumArray.Add(liczba);
    }

    /// <summary>
    /// Sortuje liczby rosnąco metodą bąbelkową
    /// </summary>
    public void Posortuj()
    {
        int length = NumArray.Count();

        if (length >= 2)
        {
            for (int i=0; i < length; i++)
            {
                for (int j=0; j < length - 1; j++)
                {
                    if (NumArray[j] > NumArray[j+1])
                    {
                        double temp = NumArray[j+1];
                        NumArray[j+1] = NumArray[j];
                        NumArray[j] = temp;
                    }
                }
            }
        }
    }
    /// <summary>
    /// Wyświetla wszystkie elementy tablicy
    /// </summary>
    public void WyswietlTablice()
    {
        int length = NumArray.Count();

        // Lista tekstowa wspomagająca wyświetlanie już pobranych liczb z tablicy.
        List<String> StrArray = new List<String>();

        if(length > 0) 
        { 

            for (int i=0; i < length; i++)
            {
                // Dodanie poprawnie sparsowanej wartości do listy tekstowej ze sformatowanym nawiasem.
                StrArray.Add("["+NumArray[i].ToString() + "]");
            }  

            Console.WriteLine(String.Join("", StrArray)); 
        }
    }

}
