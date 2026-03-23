using System.Collections.Generic;

namespace WyswietlLiczby
{
    /// <summary>
    /// Jest to klasa służąca do przetwarzania tablicy liczbami całkowitymi.
    /// </summary>
    internal class Liczby
    {
        /// <summary>
        /// Przechowuje dane wejściowe tablicy 
        /// </summary>
        private int[] LiczbyTab { get; set; }
        /// <summary>
        /// Przechowuje liczby niechciane w wyniku końcowym.
        /// </summary>
        private int[] NiechcianeLiczby { get; set; }
        /// <summary>
        /// Przechowuje wynik
        /// </summary>
        private List<int> Rezultat { get; set; } = new List<int>();
        /// <summary>
        /// Inicjuje nowe wystąpienie klasy Liczby z określonymi tablicami liczb oraz liczb niepożądanych, oraz wywołuje metodę.
        /// </summary>
        /// <param name="liczbyTab">Tablica liczb całkowitych, które mają zostać przetworzone. Nie może być null.</param>
        /// <param name="niechcianeLiczby">Tablica liczb całkowitych, które mają zostać wykluczone z przetwarzania. Nie może być null.</param>
        public Liczby (int[] liczbyTab, int[] niechcianeLiczby)
        {
            this.LiczbyTab = liczbyTab;
            this.NiechcianeLiczby = niechcianeLiczby;

            WygenerujWynik();
        }

        /// <summary>
        /// Metoda przetwarza tablice liczb i zapisuje wynik do listy.
        /// </summary>
        private void WygenerujWynik()
        {
            for (int i = 0; i < LiczbyTab.Length; i++)
            {
                bool jestNiechciana = false;
                for (int j = 0; j < NiechcianeLiczby.Length; j++)
                {
                    if (LiczbyTab[i] == NiechcianeLiczby[j])
                    {
                        jestNiechciana = true;
                        break;
                    }
                }

                if (jestNiechciana == true)
                {
                    continue; // Jeśli liczba jest niechciana, przechodzimy do następnej iteracji zewnętrznej pętli
                }

                Rezultat.Add(LiczbyTab[i]);
            }
        }
        /// <summary>
        /// Wyswietla tablice wyników w konsoli.
        /// </summary>
        public void WyswietlWynik()
        {
            for (int i=0; i<Rezultat.Count; i++)
            {
                Console.WriteLine($"[{Rezultat[i]}]");
            }
        }
    }
}
