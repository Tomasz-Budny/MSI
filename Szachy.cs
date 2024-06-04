public class Szachy : Gra
{
    private figurySzachowe[][] plansza;
    private Dictionary<string, List<figurySzachowe>> figuryGraczy; // figury dla każdego z graczy

    public Szachy(string nazwa, float sredniCzasTrwania) : base(nazwa, 2, sredniCzasTrwania)
    {
        // ustawia domyślne ustawienie figur
    }

    public override void uzyjPodstawowychUstawien()
    {
        base.uzyjPodstawowychUstawien();
    }
    public override bool glownaPetlaRozgrywki()
    {
        // obsługuję turę gracza, przesuwając figury i sprawdza, czy jest szach lub mat
        // przy macie zwraca true, w pozostałych przypadkach false
        return base.glownaPetlaRozgrywki();
    }
}
public enum figurySzachowe{
    pionek, skoczek, wieza, goniec, hetman, krol, pusto
}