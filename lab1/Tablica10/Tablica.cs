using System;
using System.Collections.Generic;
using System.Text;

namespace Tablica10
{
    internal class Tablica
    {
        private double[] tablica;

        public double Suma { get; private set; }
        public double Iloczyn { get; private set; }
        public double Srednia { get; private set; }
        public double Min { get; private set; }
        public double Max { get; private set; }

        public Tablica(double[] tablica)
        {
            this.tablica = tablica;

            ObliczSume();
            ObliczIloczyn();
            ObliczSrednia();
            ObliczMin();
            ObliczMax();
        }

        public void WyswietlTablice()
        {

            Console.WriteLine($"[{tablica[0]}][{tablica[1]}][{tablica[2]}][{tablica[3]}][{tablica[4]}][{tablica[5]}][{tablica[6]}][{tablica[7]}][{tablica[8]}][{tablica[9]}]");

        }

        private void ObliczSume()
        {
            for (int i = 0; i < tablica.Length; i++)
            {
                Suma += tablica[i];
            }
        }

        private void ObliczIloczyn()
        {
            for (int i = 0; i < tablica.Length; i++)
            {
                Iloczyn *= tablica[i];
            }
        }

        private void ObliczSrednia()
        {
            Srednia = Suma / tablica.Length;
        }

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
