using WyswietlLiczby;

// Deklaracja zmiennych
int[] liczbyTab = Enumerable.Range(1, 20).ToArray();
int[] niechcianeLiczby = { 2, 6, 9, 15, 19 };

// Tworzenie objektu klasy 
Liczby obj = new Liczby(liczbyTab, niechcianeLiczby);

// Wywołanie metody 
obj.WyswietlWynik();