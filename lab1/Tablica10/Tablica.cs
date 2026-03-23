using System;
using System.Collections.Generic;
using System.Text;

namespace Tablica10
{
    /// <summary> 
    /// Klasa służąca do wyliczenia wartości na tablicy typu <see cref="double"/>. 
    /// </summary> 
    /// <remarks>
    /// Obliczenia wykonywane są w konstruktorze klasy.
    /// </remarks>
    internal class Tablica
    {
        /// <summary>
        /// Tablica przekazywana do obliczeń.
        /// </summary>
        private double[] tablica;
        /// <summary>
        /// Suma wszystkich elementów tablicy.
        /// </summary>
        public double Suma { get; private set; }
        /// <summary>
        /// Iloczyn wszystkich elementów tablicy.
        /// </summary>
        public double Iloczyn { get; private set; }
        /// <summary>
        /// Srednia wszystkich elementów tablicy.
        /// </summary>
        public double Srednia { get; private set; }
        /// <summary>
        /// Minimum wszystkich elementów tablicy.
        /// </summary>
        public double Min { get; private set; }
        /// <summary>
        /// Maksimum wszystkich elementów tablicy.
        /// </summary>
        public double Max { get; private set; }

        /// <summary>
        /// Konstruktor, zawiera przypisanie parametru wejściowego do zmiennej, oraz wywołanie metod obliczających wartości.
        /// </summary>
        /// <param name="tablica">Tablica wartości na której operują metody </param>
        public Tablica(double[] tablica)
        {
            this.tablica = tablica;

            ObliczSume();
            ObliczIloczyn();
            ObliczSrednia();
            ObliczMin();
            ObliczMax();
        }

        /// <summary>
        /// Wyświetla wszystkie elementy tablicy.
        /// </summary>
        public void WyswietlTablice()
        {

            Console.WriteLine($"[{tablica[0]}][{tablica[1]}][{tablica[2]}][{tablica[3]}][{tablica[4]}][{tablica[5]}][{tablica[6]}][{tablica[7]}][{tablica[8]}][{tablica[9]}]");

        }

        /// <summary>
        /// Wylicza sumę wszystkich elementów tablicy.
        /// </summary>
        private void ObliczSume()
        {
            for (int i = 0; i < tablica.Length; i++)
            {
                Suma += tablica[i];
            }
        }

        /// <summary>
        /// wylicza Iloczyn wszystkich elementów tablicy.
        /// </summary>
        private void ObliczIloczyn()
        {
            for (int i = 0; i < tablica.Length; i++)
            {
                if (i == 0)
                {
                    Iloczyn = tablica[0];
                }
                else
                {
                    Iloczyn *= tablica[i];
                }
            }
        }

        /// <summary>
        /// Oblicza średnią wszystkich elementów tablicy.
        /// </summary>
        private void ObliczSrednia()
        {
            Srednia = Suma / tablica.Length;
        }

        /// <summary>
        /// Oblicza minimum wszystkich elementów tablicy.
        /// </summary>
        private void ObliczMin()
        {
            for (int i = 0;i < tablica.Length;i++)
            {

                if (i == 0)
                {
                    Min = tablica[i];
                }

                if (tablica[i] < Min)
                {
                    Min = tablica[i];
                }
            }
        }

        /// <summary>
        /// Oblicza maksimum wszystkich elementów tablicy.
        /// </summary>
        private void ObliczMax()
        {
            for (int i = 0; i < tablica.Length; i++)
            {
                if (i == 0)
                {
                    Max = tablica[i];
                }

                if (tablica[i] > Max)
                {
                    Max = tablica[i];
                }
            }
        }
    }
}
