// Program.cs 


// deklaracja zmiennych
// zmienne wejściowe
double a;
double b;
double c;

// wczytywanie zmiennej a 
Console.WriteLine("Podaj wartość zmiennej a (różny od 0):  ");
// walidacja sprawdzająca czy a może być przekonwertowane do formatu double oraz a != 0
while (!double.TryParse(Console.ReadLine(), out a) || a == 0)
{
    Console.Clear();
    Console.WriteLine("Błąd! Spróbuj jeszcze raz.");
    Console.WriteLine("Podaj wartość zmiennej a (różny od 0):  ");

}

// wczytywanie zmiennej b
Console.WriteLine("Podaj wartość zmiennej b: ");
// walidacja sprawdzająca czy b może być przekonwertowane do formatu double
while (!double.TryParse(Console.ReadLine(), out b))
{
    Console.Clear();
    Console.WriteLine("Błąd! Spróbuj jeszcze raz.");
    Console.WriteLine("Podaj wartość zmiennej b: ");
}

// wczytywanie zmiennej c
Console.WriteLine("Podaj wartość zmiennej c: ");
// walidacja sprawdzająca czy c może być przekonwertowane do formatu double
while (!double.TryParse(Console.ReadLine(), out c))
{
    Console.Clear();
    Console.WriteLine("Błąd! Spróbuj jeszcze raz.");
    Console.WriteLine("Podaj wartość zmiennej c: ");
}

// tworzenie obiektu klasy TrojmianKwadratowy
TrojmianKwadratowy funkcja = new TrojmianKwadratowy(a, b, c);

Console.WriteLine($"\nTrójmian: {a}^x2 + {b}x + {c}\n");
Console.WriteLine($"Delta = {funkcja.Delta}\n");

if (funkcja.Delta > 0)
{
    Console.WriteLine("Rozwiązania:\n");
    Console.WriteLine($"X1 = {funkcja.X1}");
    Console.WriteLine($"X2 = {funkcja.X2}");
}
else if (funkcja.Delta == 0)
{
    Console.WriteLine("Rozwiązanie:\n");
    Console.WriteLine($"X1 = {funkcja.X1}");
}
else 
{ 
    Console.WriteLine("Brak rozwiązań"); 
}


// Console.WriteLine($"f(x) =  {a}x^2 + {b}x + {c}");


