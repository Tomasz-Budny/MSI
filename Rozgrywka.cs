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
        // TODO: Napisz co to robi
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
        // TODO: czym to siê ró¿ni od ZakoñczRozgrywkê?
    }

    public void WyjdŸZTworzeniaGry()
    {
        // TODO: Jak to napisaæ
    }

    public List<Gra> PobierzInformacjeOGrze()
    {
        // TODO: SprawdŸ czy to dobrze jak nie to popraw

        return Gra.wyszukajGry();
    }

    public void WyœwietlKomunikatODo³¹czeniuGracza() { }

    public void WyœwietlKomunikatOWyjœciuGracza() { }

    public void WyœwietlInfoOGrze()
    {
        // Wyœwietla info o grze jak tabela rankingowa lokalan czas trwania gry
        // TODO: Zobacz czy dobrze
    }

    public static void Do³¹cz(Gracz gracz)
    {
        // sprawdza czy liczba graczy z tym graczem nie bêdzie przekraczaæ maksymalnej liczby - jeœli nie dodaje go do listy graczy
        // TODO: SprawdŸ swój diagram sekwencji i zweryfikuj dzia³anie tej metody - najwy¿ej popraw tu
    }

    public static Rozgrywka Wyszukaj(string nazwa)
    {
        // zwraca rozgrywkê po nazwie
        return rozgrywki.First(rozgrywka => rozgrywka.nazwaRozgrywki == nazwa);
    }

    public void StwórzLobby()
    {
        // TODO: Obczaj jak to TECHNICZNIE powinno dzia³aæ
    }

    public void EdytujUstawienia()
    {
        // TODO: Jakie ustawienia
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
        // TODO: Opisz co to robi
    }

    public void Zarz¹dzajGraczami()
    {
        // TODO: Opisz co to robi
    }

    public void ZapiszWyniki()
    {
        // TODO: Czy to potrzebne? Mamy metodê do aktualizowania rankingu
    }

    public void ZapiszRozgrywkê()
    {
        // TODO: jak to ma dzia³aæ? mamy metodê do dodawania do ekstensji - stwórz rozgrywkê
    }

    public void WybierzHas³o()
    {
        // Pozwala ustawiæ has³o na rozgrywce prywatnej
    }

    public void WybierzSerwer()
    {
        serwer = Serwer.wybierzNajblizszySerwer(hostRozgrywki.Kraj);
    }

    public void SprawdŸHas³o()
    {
        // TODO: Co to metoda ma robiæ?
    }

    public void WykonajTurêDlaGracza(Gracz gracz)
    {
        // Sprawdza czy gracz istnieje nastêpnie pozwala mu wykonaæ turê odpalaj¹c metodê g³óna pêtla rozgrywki. Na koniec aktualizuje lokalny ranking
        // TODO: Trzeba przemyœleæ jak œledziæ proces w rozgrywce - póki co ten element kuleje u nas. Ja bym proponowa³ zaktualizowaæ g³ówn¹ pêtle rozgrywki tak aby zwraca³a wyniki poszczególnych
        // graczy ew. posortowano wed³ug tego kto wygrywa listê. Pewnie przyda³oby siê na Grze mieæ referencje do graczy i zrobiæ z tego jakiœ s³ownik punktów. Jak masz lepszy pomys³ pomyœl i zaimplementuj.
    }
}