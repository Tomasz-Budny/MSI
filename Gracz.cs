
public class Gracz : Uzytkownik
{
    public string pseudonim { get; private set; }
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

    public void Zg³oœGracza(Zg³oszenie zg³oszenie)
    {
        // tworzy nowe zg³oszenie z danymi zg³aszanego gracza
        Zg³oszenie.DodajZg³oszenie(zg³oszenie);
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

    public void WyœwietlListêRankingowo()
    {
        // wyœwietla listê rankingowo w zale¿noœci od wyników gracza z rangami
    }

    public Rozgrywka StwórzRozgrywkê()
    {
        // Tworzy now¹ rozgrywkê
        return new Rozgrywka();
    }

    public Rozgrywka WyszukajRozgrywke(string nazwa)
    {
        return Rozgrywka.Wyszukaj(nazwa);
    }

    public void Do³¹czDoRozgrywki(Rozgrywka rozgrywka)
    {
        // Tworzy proœbê o do³¹czenie - z obecnym graczem oraz z wybran¹ rozgrywk¹
        var proœbaODo³¹czenie = new ProsbaDolaczenia();
        proœbaODo³¹czenie.dolacz();
    }

    public void ZaproœDoRozgrywki(Gracz gracz)
    {
        // Tworzy prosbê o do³¹czenie z wybranym graczem oraz obecnie rozgrywan¹ rozgrywk¹ pobieran¹ z historii rozegranych rozgrywek
    }

    public void UstawStatusDostêpny()
    {
        status = Status.Dostêpny;
    }

    public void UstawStatusWRozgrywce()
    {
        status = Status.WRozgywce;
    }

    public void UstawStatusZablokowany()
    {
        status = Status.Zablokowany;
    }

    public void PoproœOOdblokowanie()
    {
        // tworzy proœbê o odblokowanie
        var proœba = new ProœbaOOdblokowanie();
        ProœbaOOdblokowanie.Dodaj(proœba);
    }

    public void WykonajTurê()
    {
        historiaRozgrywek.Last().WykonajTurêDlaGracza(this);
    }
}