public abstract class Gra
{
    string nazwa;
    int maksymalnaIloscGraczy;
    float sredniCzasTrwania; //orientacyjny czas
    Rozgrywka powiązanaRozgrywka; // pozwala na dostęp do graczy

    static List<Gra> gry;

    public Gra(string nazwa, int maksymalnaIloscGraczy, float sredniCzasTrwania, Rozgrywka powiązanaRozgrywka)
    {
        this.nazwa = nazwa;
        this.maksymalnaIloscGraczy = maksymalnaIloscGraczy;
        this.sredniCzasTrwania = sredniCzasTrwania;
        this.powiązanaRozgrywka = powiązanaRozgrywka;
    }
    
    public static List<Gra> wyszukajGry()
    {
        // dodatkowo filtrowanie wyszukiwania
        return gry;
    }

    public virtual void uzyjPodstawowychUstawien(){
        //standardowe ustawienia
    }
    public virtual bool glownaPetlaRozgrywki(){
        //standardowa obsługa systemów turowych
        //jesli tura w którj została uruchomiona jest turą w której ktoś wygrał
        bool czyZakonczona = false; // domyslnie zwraca false, metoda i tak zostaje nadpisana w dziedziczeniu

        return czyZakonczona;
    }
}