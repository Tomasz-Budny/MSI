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
        // aktualizuje informacje zwi�zane w gr� podczas ka�dej tury
        // np ilosc pieniedzy gracza w monopoly,
        // lub czy gracz szachuje kr�la w szachach
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
        // uruchamiane w sytuacji gdy rozgrywka nie zako�czy�a si� prawid�owo
        // gdy host lub gracze wyszli z gry przed jej zako�czeniem
    }

    public Gra PobierzInformacjeOGrze(int id_gry)
    {

        return Gra.wyszukajGry()[id_gry];
    }

    public void Wy�wietlKomunikatODo��czeniuGracza() { }

    public void Wy�wietlKomunikatOWyj�ciuGracza() { }

    public void Wy�wietlInfoOGrze()
    {
        // Wy�wietla info o grze jak tabela rankingowa, czas trwania gry, obecni gracze
    }

    public void Do��cz(Gracz gracz)
    {
        // sprawdza czy liczba graczy z tym graczem nie b�dzie przekracza� maksymalnej liczby - je�li nie dodaje go do listy graczy oczekuj�cych w lobby
    }

    public static Rozgrywka Wyszukaj(string nazwa)
    {
        // zwraca rozgrywk� po nazwie
        return rozgrywki.First(rozgrywka => rozgrywka.nazwaRozgrywki == nazwa);
    }

    public void Stw�rzLobby()
    {
        // inicjuje list� graczy
        gracze = new List<Gracz>();
        gracze.Add(hostRozgrywki);
    }

    public void EdytujUstawienia()
    {
        // typu maksymalna liczba graczy
        // lub zmiana/dodanie/usuni�cie has�a
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
        // Pyta gracza czy chce spr�bowa� po��czy� si� ponownie z rozgrywk�
    }

    public void Zarz�dzajGraczami()
    {
        // wy�wietla hostowi panel pozwalaj�cy wyrzuca� i dodawa� graczy
    }

    public void ZapiszRozgrywk�()
    {
        // Zapisuje dane o rozgrywce w oddzielnej bazie danych (np do przysz�ej analizy)
    }

    public void WybierzHas�o()
    {
        // Pozwala ustawi� has�o na rozgrywce prywatnej
    }

    public void WybierzSerwer()
    {
        serwer = Serwer.wybierzNajblizszySerwer(hostRozgrywki.Kraj);
    }

    public bool Sprawd�Has�o(string haslo)
    {
        // Metoda wywo�ywana przez Sprawd�Has�o z klasy Pro�baDo��czenia
        // sprawdza czy has�o podane podczas do��czania zgadza si� z ustawionym przez hosta
        // jest to oddzielna metoda, aby unikn�c publicznego dost�pu do pola z has�em
        return haslo.Equals(this.has�o); // uproszczona metoda bez hashowania
    }

    public void WykonajTur�DlaGracza(Gracz gracz)
    {
        // Sprawdza czy gracz istnieje nast�pnie pozwala mu wykona� tur� odpalaj�c metod� g��wna p�tla rozgrywki. Na koniec aktualizuje lokalny ranking
        // TODO: Trzeba przemy�le� jak �ledzi� proces w rozgrywce - p�ki co ten element kuleje u nas. Ja bym proponowa� zaktualizowa� g��wn� p�tle rozgrywki tak aby zwraca�a wyniki poszczeg�lnych
        // graczy ew. posortowano wed�ug tego kto wygrywa list�. Pewnie przyda�oby si� na Grze mie� referencje do graczy i zrobi� z tego jaki� s�ownik punkt�w. Jak masz lepszy pomys� pomy�l i zaimplementuj.
    }
}