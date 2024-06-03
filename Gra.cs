public abstract class Gra
{
    string nazwa;
    int maksymalnaIloscGraczy;
    float sredniCzasTrwania; //orientacyjny czas
    List<Gracz> graczeWGrze = new List<Gracz>();

    static List<Gra> gry;

    public Gra(string nazwa, int maksymalnaIloscGraczy, float sredniCzasTrwania)
    {
        this.nazwa = nazwa;
        this.maksymalnaIloscGraczy = maksymalnaIloscGraczy;
        this.sredniCzasTrwania = sredniCzasTrwania;
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