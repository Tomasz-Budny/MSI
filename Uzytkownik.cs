using System.Data.SqlTypes;
using System.Security.Cryptography;

public abstract class Uzytkownik
{
    protected string imie;
    protected string nazwisko;
    protected string email;
    protected string hasło = "";
    protected int wiek;
    protected DateTime dataUrodzenia;
    protected int maxLiczbaCzatow = 20;
    protected int minimalnyWiek = 12;

    public List<Czat> czaty = new List<Czat>();

    protected bool zablokowany = false;

    protected string kraj;

    public string Kraj { get; private set; }
    public Uzytkownik(string imie, string nazwisko, string email, int wiek, DateTime dataUrodzenia, string kraj)
    {
        this.imie = imie; this.nazwisko=nazwisko; this.email = email; this.wiek = wiek; this.dataUrodzenia = dataUrodzenia; this.kraj = kraj;
    }
    public void wylogowanieZSystemu()
    {
        throw new NotImplementedException();
    }
    public void zmianaHasła(string stareHasło, string noweHasło)
    {
        // metoda porównuje zahashowane stareHasło do aktualnego
        // jeśli się zgadzają, hashuje noweHasło i zapisuje
    }
    public void zmianaInformacjiPodstawowych(string imie, string nazwisko, string email)
    {
        this.imie = imie;
        this.nazwisko = nazwisko;
        this.email = email;
    }
}