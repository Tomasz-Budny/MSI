
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
        var wygraneRozgrywki = gracz.historiaRozgrywek.Count(rozgrywka => rozgrywka.zwyci�zca == gracz);

        var ratio = wygraneRozgrywki / rozegraneRozgrywki;

        // na podstawie ratio wszystkich wynik�w innych graczy ustala jego pozycje

        // ustala rang� na podstawie tego w kt�rym centylu w rankingu znajduj� si� gracz
    }

    public static Gracz WyszukajGracza(string pseudonim)
    {
        // Zwraca gracza z danym nickiem je�li nie ma wyrzuca b��d

        return gracze.First(gracz => gracz.pseudonim == pseudonim);
    }
}