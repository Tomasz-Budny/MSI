public abstract class Gra
{
    string nazwa;
    int maksymalnaIloscGraczy;
    float sredniCzasTrwania; //orientacyjny czas

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
    public virtual void glownaPetlaRozgrywki(){
        //standardowa obsługa systemów turowych
    }
}