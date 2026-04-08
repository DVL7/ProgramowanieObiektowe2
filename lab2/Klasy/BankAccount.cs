namespace Klasy;

public class BankAccount
{
    public string Wlasciciel { get; private set; }
    public decimal Saldo { get; private set; }

    public BankAccount(string wlasciciel, decimal kwotaPoczatkowa)
    {
        if (string.IsNullOrEmpty(wlasciciel))
        {
            throw new ArgumentException("Dane właściciel nie mogą być puste", nameof(wlasciciel));
        }
        if (kwotaPoczatkowa < 0m)
        {
            throw new ArgumentException("Kwota początkowa nie może być ujemna", nameof(kwotaPoczatkowa));
        }

        Wlasciciel = wlasciciel;
        Saldo = kwotaPoczatkowa;

    }

    public void Wplata(decimal kwota)
    {
        Saldo += kwota;
    }

    public void Wyplata(decimal kwota)
    {
        if (!(Saldo - kwota < 0))
        {
            Saldo -= kwota;
        }
        else
        {
            Console.WriteLine("Przelew nie powiódł się. Zbyt mały stan konta.");
        }
    }




}