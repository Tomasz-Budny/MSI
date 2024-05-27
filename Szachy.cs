public class Szachy : Gra
{
    private string[] figury;

    public Szachy(string nazwa, float sredniCzasTrwania) : base(nazwa, 2, sredniCzasTrwania)
    {
        // ustawia domyślne ustawienie figur
    }

    public override void uzyjPodstawowychUstawien()
    {
        base.uzyjPodstawowychUstawien();
    }
    public override void glownaPetlaRozgrywki()
    {
        base.glownaPetlaRozgrywki();
    }
}
public enum figurySzachowe{
    pionek, skoczek, wieza, goniec, hetman, krol
}