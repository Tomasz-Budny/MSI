public class Rozgrywka
{
    string nazwaRozgrywki;
    int aktualnaLiczbaGraczy;
    int minimalnaLiczbaGraczyPotrzebnaDoRozpocz�cia;
    float maksymalnyCzasTrwaniaGry;
    int maksymalnaLiczbaGraczy;
    Ranga minimalnaRanga;
    string? has�o;
    public Gracz zwyci�zca {  get; private set; }
    Gracz hostRozgrywki;
    bool publiczna;
    bool rankingowa;
    Serwer serwer;
    Gra gra;
    List<Gracz> lokalny_ranking;
    List<Gracz> gracze;

    static List<Rozgrywka> rozgrywki;

    public void RozpocznijRozgrywk�()
    {
        if (aktualnaLiczbaGraczy < minimalnaLiczbaGraczyPotrzebnaDoRozpocz�cia)
            throw new Exception();

        if (aktualnaLiczbaGraczy > maksymalnaLiczbaGraczy)
            throw new Exception();

        // Rozpoczyna rozgrywke

        gra.uzyjPodstawowychUstawien();
        UstawKolejno��Graczy();
        gra.glownaPetlaRozgrywki();
    }

    public void Zako�czRozgrywk�()
    {
        zwyci�zca = lokalny_ranking[0];

        AktualizujRanking();
    }

    public void RestartujRozgrywke()
    {
        lokalny_ranking = null;
        RozpocznijRozgrywk�();
    }

    public void Zapro�Znajomego(string pseudonim)
    {
        var gracz = Gracz.WyszukajGracza(pseudonim);
        gracze.Add(gracz);
    }

    public void Wy�wietlUstawienia()
    {
        // zwraca ustawieienia takie jak typ rozgrywki, serwer, minimalna rang� oraz haso
        // TODO: Zobacz czy to si� zgadza bo chyba ty robi�e� to metod�
    }

    public void WybierzGr�(Gra wybranaGra)
    {
        gra = wybranaGra;
    }

    private void UstawKolejno��Graczy()
    {
        // ustawia graczy w kolejno�ci w jakiej b�d� wykonywa� swoje tury
    }

    private void AktualizujInfo()
    {
        // TODO: Napisz co to robi
    }

    private void AktualizujRanking()
    {
        foreach (var gracz in gracze)
        {
            Gracz.aktualizujPozycjeWRankingu(gracz);
        }
    }

    public void PrzerwijRozgrywk�()
    {
        // TODO: czym to si� r�ni od Zako�czRozgrywk�?
    }

    public void Wyjd�ZTworzeniaGry()
    {
        // TODO: Jak to napisa�
    }

    public List<Gra> PobierzInformacjeOGrze()
    {
        // TODO: Sprawd� czy to dobrze jak nie to popraw

        return Gra.wyszukajGry();
    }

    public void Wy�wietlKomunikatODo��czeniuGracza() { }

    public void Wy�wietlKomunikatOWyj�ciuGracza() { }

    public void Wy�wietlInfoOGrze()
    {
        // Wy�wietla info o grze jak tabela rankingowa lokalan czas trwania gry
        // TODO: Zobacz czy dobrze
    }

    public static void Do��cz(Gracz gracz)
    {
        // sprawdza czy liczba graczy z tym graczem nie b�dzie przekracza� maksymalnej liczby - je�li nie dodaje go do listy graczy
        // TODO: Sprawd� sw�j diagram sekwencji i zweryfikuj dzia�anie tej metody - najwy�ej popraw tu
    }

    public static Rozgrywka Wyszukaj(string nazwa)
    {
        // zwraca rozgrywk� po nazwie
        return rozgrywki.First(rozgrywka => rozgrywka.nazwaRozgrywki == nazwa);
    }

    public void Stw�rzLobby()
    {
        // TODO: Obczaj jak to TECHNICZNIE powinno dzia�a�
    }

    public void EdytujUstawienia()
    {
        // TODO: Jakie ustawienia
    }

    public void Wy�wietlFormatk�DanychPodstawowych() { }

    public static Rozgrywka Stw�rzRozgrywk�()
    {
        var nowa = new Rozgrywka();
        rozgrywki.Add(nowa);

        return nowa;
    }

    public void UstawLiczb�Graczy(int minimalna, int maksymalna)
    {
        minimalnaLiczbaGraczyPotrzebnaDoRozpocz�cia = minimalna;
        maksymalnaLiczbaGraczy = maksymalna;
    }

    public void WybierzTypRozgrywki()
    {
        // Pozwala wybra� typ rozgrywki - publiczna, prywatna, rankinowa nie
    }

    public void Udost�pnijRozgrywk�NaSerwerze()
    {
        // udost�pnia rozgrywk� na uprzednio wybranym serwerze
        serwer.dodajRozgrywke(this);
    }

    public void InformujCzyLobbyPe�ne() { }

    public void Pon�wPr�beDo��czenia()
    {
        // TODO: Opisz co to robi
    }

    public void Zarz�dzajGraczami()
    {
        // TODO: Opisz co to robi
    }

    public void ZapiszWyniki()
    {
        // TODO: Czy to potrzebne? Mamy metod� do aktualizowania rankingu
    }

    public void ZapiszRozgrywk�()
    {
        // TODO: jak to ma dzia�a�? mamy metod� do dodawania do ekstensji - stw�rz rozgrywk�
    }

    public void WybierzHas�o()
    {
        // Pozwala ustawi� has�o na rozgrywce prywatnej
    }

    public void WybierzSerwer()
    {
        serwer = Serwer.wybierzNajblizszySerwer(hostRozgrywki.Kraj);
    }

    public void Sprawd�Has�o()
    {
        // TODO: Co to metoda ma robi�?
    }

    public void WykonajTur�DlaGracza(Gracz gracz)
    {
        // Sprawdza czy gracz istnieje nast�pnie pozwala mu wykona� tur� odpalaj�c metod� g��na p�tla rozgrywki. Na koniec aktualizuje lokalny ranking
        // TODO: Trzeba przemy�le� jak �ledzi� proces w rozgrywce - p�ki co ten element kuleje u nas. Ja bym proponowa� zaktualizowa� g��wn� p�tle rozgrywki tak aby zwraca�a wyniki poszczeg�lnych
        // graczy ew. posortowano wed�ug tego kto wygrywa list�. Pewnie przyda�oby si� na Grze mie� referencje do graczy i zrobi� z tego jaki� s�ownik punkt�w. Jak masz lepszy pomys� pomy�l i zaimplementuj.
    }
}