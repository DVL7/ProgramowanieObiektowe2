using System;

/// <summary>
/// Klasa służąca do obliczania trójmianu kwadratowego. 
/// </summary>
public class TrojmianKwadratowy
{

	private double a;
    private double b;
    private double c;

    // Właściwości (gettery) dla rozwiązań. Używamy double?, bo mogą nie istnieć.
    public double? X1 { get; private set; }
    public double? X2 { get; private set; }
    public double Delta { get; private set; }

    public TrojmianKwadratowy(double a, double b, double c)
	{
		this.a = a;
		this.b = b;
		this.c = c;

		ObliczDelte();
		WyznaczRozwiazania();
	}

	private void ObliczDelte()
	{
		// Oblicz wartość delty (double) 
		Delta =  (b*b - (4 * a * c));
	}

	private void WyznaczRozwiazania()
	{

        // delta > 0 - dwa rozwiązania
        if (Delta > 0)
		{
			// rozwiązanie 1 
			X1 = (-b + Math.Sqrt(Delta)) / (2 * a);
			// rozwiązanie 2
			X2 = (-b - Math.Sqrt(Delta)) / (2 * a);

		}
		// delta == 0 - jedno rozwiązanie
		else if (Delta == 0)
		{
			X1 = -b / (2 * a);
		}
		// Delta ujemna - brak rozwiązań
		else { }
	}
}
