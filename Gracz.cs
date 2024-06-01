
public class Gracz : Uzytkownik
{
    string pseudonim;
    List<Rozgrywka> historiaRozgrywek = new();
    Ranga ranga;
    int pozycjaWRankingu;
    List<Gracz> znajomi;
    Status status;

    static List<Gracz> gracze;


    public Gracz(string imie, string nazwisko, string email, int wiek, DateTime dataUrodzenia, string kraj) : base(imie, nazwisko, email, wiek, dataUrodzenia, kraj)
    {
    }

    public static void aktualizujPozycjeWRankingu(Gracz gracz)
    {
        var rozegraneRozgrywki = gracz.historiaRozgrywek.Count;
        var wygraneRozgrywki = gracz.historiaRozgrywek.Count(rozgrywka => rozgrywka.zwyciêzca == gracz);

        var ratio = wygraneRozgrywki / rozegraneRozgrywki;

        // na podstawie ratio wszystkich wyników innych graczy ustala jego pozycje

        // ustala rangê na podstawie tego w którym centylu w rankingu znajdujê siê gracz
    }

    public static Gracz WyszukajGracza(string pseudonim)
    {
        // Zwraca gracza z danym nickiem jeœli nie ma wyrzuca b³¹d

        return gracze.First(gracz => gracz.pseudonim == pseudonim);
    }
}