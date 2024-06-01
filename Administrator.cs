public class Administrator : Uzytkownik
{
    private List<String> uprawnienia = new List<string>();
    private List<Serwer> nadzorowaneSerwery = new List<Serwer>();
    private List<Zgłoszenie> rozpatrzoneZgłoszenia = new List<Zgłoszenie>();
    static int maxIloscAdministratorow = 5;

    public Administrator(string imie, string nazwisko, string email, int wiek, DateTime dataUrodzenia, string kraj) : base(imie, nazwisko, email, wiek, dataUrodzenia, kraj)
    {
    }

    private void blokowanieUzytkownikow(string Pseudonim)
    {
        // metoda blokuje użytkwnika o danym pseudonimie
        
    }
    private void UsunSerwer(Serwer serwer) {}
    private void StwórzSerwer() {}
}