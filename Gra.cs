public abstract class Gra
{
    string nazwa;
    int maksymalnaIloscGraczy;
    float sredniCzasTrwania; //orientacyjny czas

    public Gra(string nazwa, int maksymalnaIloscGraczy, float sredniCzasTrwania)
    {
        this.nazwa = nazwa;
        this.maksymalnaIloscGraczy = maksymalnaIloscGraczy;
        this.sredniCzasTrwania = sredniCzasTrwania;
    }
    
    public virtual void uzyjPodstawowychUstawien(){
        //standardowe ustawienia
    }
    public virtual void glownaPetlaRozgrywki(){
        //standardowa obsługa systemów turowych
    }
}