using System.Data.Common;

public class Osoba
{
    private string imie;
    private string nazwisko;
    private int? wiek;
    public Osoba(string imie, string nazwisko, int? wiek)
    {
        this.imie = imie;
        this.nazwisko = nazwisko;
        this.wiek = wiek;
    }
    public Osoba(string imie, string nazwisko) : this(imie, nazwisko, null) { }

    public static explicit operator string(Osoba osoba)
    {
        return $"{osoba.imie} {osoba.nazwisko}";
    }

    public static implicit operator Osoba(string str)
    {
        string[] czesci = str.Split(' ');
        if (czesci.Length == 2)
        {
            return new Osoba(czesci[0], czesci[1]);
        }
        else if (czesci.Length == 3)
        {
            if (int.TryParse(czesci[2], out int wiek))
            {
                return new Osoba(czesci[0], czesci[1], wiek);
            }
            else
            {
                throw new ArgumentException("Wiek musi być liczbą całkowitą.");
            }
        }
        throw new ArgumentException("Niepoprawny format imienia, nazwiska i wieku. Oczekiwany format: 'Imię Nazwisko Wiek'. Wiek w postaci liczby!");
    }

    public string this[int index]
    {
        get
        {
            if (index == 0)
            {
                return this.imie;
            }
            else if (index == 1)
            {
                return this.nazwisko;
            }
            else if (index == 2)
            {
                if (this.wiek != null)
                {
                    return this.wiek.ToString();
                }
                else
                {
                    return "Wiek nieznany";
                }
            }
            else
            {
                throw new IndexOutOfRangeException("Indeks poza zakresem. Dozwolone indeksy: 0 (imię), 1 (nazwisko), 2 (wiek).");
            }
        }
    }

    public override string ToString()
    {
        return $"{this.imie} {this.nazwisko} {this.wiek}";
    }
}