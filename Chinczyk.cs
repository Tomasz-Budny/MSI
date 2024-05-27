public class Chinczyk : Gra
{
    //słownik przechowujący na jakiej pozycji znajduje się każdy pionek
    private Dictionary<int, int> pionki = new Dictionary<int, int>();
    public Chinczyk(string nazwa, float sredniCzasTrwania, int iloscGraczy) : base(nazwa, 4, sredniCzasTrwania)
    {
        //ustawia pionki na pozycjach startowych, zależnie od maksymalnej liczby
    }
    public virtual void uzyjPodstawowychUstawien(){}
    public virtual void glownaPetlaRozgrywki(){}
}