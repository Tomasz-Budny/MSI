public class Rozgrywka
{
    string nazwaRozgrywki;
    int aktualnaLiczbaGraczy;
    int minimalnaLiczbaGraczyPotrzebnaDoRozpoczêcia;
    float maksymalnyCzasTrwaniaGry;
    int maksymalnaLiczbaGraczy;
    Ranga minimalnaRanga;
    string? has³o;
    public Gracz zwyciêzca {  get; private set; }
    Gracz hostRozgrywki;
    bool publiczna;
    bool rankingowa;
    Serwer serwer;
    Gra gra;
    List<Gracz> lokalny_ranking;
    List<Gracz> gracze;

    static List<Rozgrywka> rozgrywki;

    public void RozpocznijRozgrywkê()
    {
        if (aktualnaLiczbaGraczy < minimalnaLiczbaGraczyPotrzebnaDoRozpoczêcia)
            throw new Exception();

        if (aktualnaLiczbaGraczy > maksymalnaLiczbaGraczy)
            throw new Exception();

        // Rozpoczyna rozgrywke

        gra.uzyjPodstawowychUstawien();
        UstawKolejnoœæGraczy();
        gra.glownaPetlaRozgrywki();
    }

    public void ZakoñczRozgrywkê()
    {
        zwyciêzca = lokalny_ranking[0];

        AktualizujRanking();
    }

    public void RestartujRozgrywke()
    {
        lokalny_ranking = null;
        RozpocznijRozgrywkê();
    }

    public void ZaproœZnajomego(string pseudonim)
    {
        var gracz = Gracz.WyszukajGracza(pseudonim);
        gracze.Add(gracz);
    }

    public void WyœwietlUstawienia()
    {
        // zwraca ustawieienia takie jak typ rozgrywki, serwer, minimalna rangê oraz haso
        // TODO: Zobacz czy to siê zgadza bo chyba ty robi³eœ to metodê
    }

    public void WybierzGrê(Gra wybranaGra)
    {
        gra = wybranaGra;
    }

    private void UstawKolejnoœæGraczy()
    {
        // ustawia graczy w kolejnoœci w jakiej bêd¹ wykonywaæ swoje tury
    }

    private void AktualizujInfo()
    {
        // aktualizuje informacje zwi¹zane w gr¹ podczas ka¿dej tury
        // np ilosc pieniedzy gracza w monopoly,
        // lub czy gracz szachuje króla w szachach
    }

    private void AktualizujRanking()
    {
        foreach (var gracz in gracze)
        {
            Gracz.aktualizujPozycjeWRankingu(gracz);
        }
    }

    public void PrzerwijRozgrywkê()
    {
        // uruchamiane w sytuacji gdy rozgrywka nie zakoñczy³a siê prawid³owo
        // gdy host lub gracze wyszli z gry przed jej zakoñczeniem
    }

    public Gra PobierzInformacjeOGrze(int id_gry)
    {

        return Gra.wyszukajGry()[id_gry];
    }

    public void WyœwietlKomunikatODo³¹czeniuGracza() { }

    public void WyœwietlKomunikatOWyjœciuGracza() { }

    public void WyœwietlInfoOGrze()
    {
        // Wyœwietla info o grze jak tabela rankingowa, czas trwania gry, obecni gracze
    }

    public void Do³¹cz(Gracz gracz)
    {
        // sprawdza czy liczba graczy z tym graczem nie bêdzie przekraczaæ maksymalnej liczby - jeœli nie dodaje go do listy graczy oczekuj¹cych w lobby
    }

    public static Rozgrywka Wyszukaj(string nazwa)
    {
        // zwraca rozgrywkê po nazwie
        return rozgrywki.First(rozgrywka => rozgrywka.nazwaRozgrywki == nazwa);
    }

    public void StwórzLobby()
    {
        // inicjuje listê graczy
        gracze = new List<Gracz>();
        gracze.Add(hostRozgrywki);
    }

    public void EdytujUstawienia()
    {
        // typu maksymalna liczba graczy
        // lub zmiana/dodanie/usuniêcie has³a
    }

    public void WyœwietlFormatkêDanychPodstawowych() { }

    public static Rozgrywka StwórzRozgrywkê()
    {
        var nowa = new Rozgrywka();
        rozgrywki.Add(nowa);

        return nowa;
    }

    public void UstawLiczbêGraczy(int minimalna, int maksymalna)
    {
        minimalnaLiczbaGraczyPotrzebnaDoRozpoczêcia = minimalna;
        maksymalnaLiczbaGraczy = maksymalna;
    }

    public void WybierzTypRozgrywki()
    {
        // Pozwala wybraæ typ rozgrywki - publiczna, prywatna, rankinowa nie
    }

    public void UdostêpnijRozgrywkêNaSerwerze()
    {
        // udostêpnia rozgrywkê na uprzednio wybranym serwerze
        serwer.dodajRozgrywke(this);
    }

    public void InformujCzyLobbyPe³ne() { }

    public void PonówPróbeDo³¹czenia()
    {
        // Pyta gracza czy chce spróbowaæ po³¹czyæ siê ponownie z rozgrywk¹
    }

    public void Zarz¹dzajGraczami()
    {
        // wyœwietla hostowi panel pozwalaj¹cy wyrzucaæ i dodawaæ graczy
    }

    public void ZapiszRozgrywkê()
    {
        // Zapisuje dane o rozgrywce w oddzielnej bazie danych (np do przysz³ej analizy)
    }

    public void WybierzHas³o()
    {
        // Pozwala ustawiæ has³o na rozgrywce prywatnej
    }

    public void WybierzSerwer()
    {
        serwer = Serwer.wybierzNajblizszySerwer(hostRozgrywki.Kraj);
    }

    public bool SprawdŸHas³o(string haslo)
    {
        // Metoda wywo³ywana przez SprawdŸHas³o z klasy ProœbaDo³¹czenia
        // sprawdza czy has³o podane podczas do³¹czania zgadza siê z ustawionym przez hosta
        // jest to oddzielna metoda, aby unikn¹c publicznego dostêpu do pola z has³em
        return haslo.Equals(this.has³o); // uproszczona metoda bez hashowania
    }

    public void WykonajTurêDlaGracza(Gracz gracz)
    {
        // Sprawdza czy gracz istnieje nastêpnie pozwala mu wykonaæ turê odpalaj¹c metodê g³ówna pêtla rozgrywki. Na koniec aktualizuje lokalny ranking
        // TODO: Trzeba przemyœleæ jak œledziæ proces w rozgrywce - póki co ten element kuleje u nas. Ja bym proponowa³ zaktualizowaæ g³ówn¹ pêtle rozgrywki tak aby zwraca³a wyniki poszczególnych
        // graczy ew. posortowano wed³ug tego kto wygrywa listê. Pewnie przyda³oby siê na Grze mieæ referencje do graczy i zrobiæ z tego jakiœ s³ownik punktów. Jak masz lepszy pomys³ pomyœl i zaimplementuj.
    }
}