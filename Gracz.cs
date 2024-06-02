
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

    public void DodajZnajomego(Gracz gracz)
    {
        // Dodaje gracza do listy znajomych
        znajomi.Add(gracz);
    }

    public void Zg�o�Gracza(Zg�oszenie zg�oszenie)
    {
        // tworzy nowe zg�oszenie z danymi zg�aszanego gracza
        Zg�oszenie.DodajZg�oszenie(zg�oszenie);
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

    public void Wy�wietlList�Rankingowo()
    {
        // wy�wietla list� rankingowo w zale�no�ci od wynik�w gracza z rangami
    }

    public Rozgrywka Stw�rzRozgrywk�()
    {
        // Tworzy now� rozgrywk�
        return new Rozgrywka();
    }

    public Rozgrywka WyszukajRozgrywke(string nazwa)
    {
        return Rozgrywka.Wyszukaj(nazwa);
    }

    public void Do��czDoRozgrywki(Rozgrywka rozgrywka)
    {
        // Tworzy pro�b� o do��czenie - z obecnym graczem oraz z wybran� rozgrywk�
        // TODO: obmy�li� jak ten schamat ma dzia�a� pro�baODo��czenie - czy ma przechowywa� referencje kto tym nadzoruje - czy to ma mie� host?
        var pro�baODo��czenie = new ProsbaDolaczenia();
    }

    public void Zapro�DoRozgrywki(Gracz gracz)
    {
        // Tworzy prosb� o do��czenie z wybranym graczem oraz obecnie rozgrywan� rozgrywk� pobieran� z historii rozegranych rozgrywek
    }

    public void UstawStatusDost�pny()
    {
        status = Status.Dost�pny;
    }

    public void UstawStatusWRozgrywce()
    {
        status = Status.WRozgywce;
    }

    public void UstawStatusZablokowany()
    {
        status = Status.Zablokowany;
    }

    public void Popro�OOdblokowanie()
    {
        // tworzy pro�b� o odblokowanie
        var pro�ba = new Pro�baOOdblokowanie();
        Pro�baOOdblokowanie.Dodaj(pro�ba);
    }

    public void WykonajTur�()
    {
        // TODO: przemy�le� mechanizm wykonywania tur
        historiaRozgrywek.Last().WykonajTur�DlaGracza(this);
    }
}