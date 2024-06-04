public class Chinczyk : Gra
{
    //słownik przechowujący na jakiej pozycji na planszy znajduje się każdy pionek konkretnego gracza
    private Dictionary<int, string> pionkiNaPlanszy = new Dictionary<int, string>();
    Dictionary<string, (int, int)> pionkiGraczy; // słownik przetrzymujący zestaw - pseudonim gracza oraz pionki jakie wprowadził do "domku" oraz te które nie wyszły na plansze
    public Chinczyk(string nazwa, float sredniCzasTrwania, int iloscGraczy) : base(nazwa, 4, sredniCzasTrwania)
    {
        //ustawia pionki na pozycjach startowych, zależnie od maksymalnej liczby
    }
    public virtual void uzyjPodstawowychUstawien(){}
	public override bool glownaPetlaRozgrywki()
	{
		// obsługuję turę gracza, zwraca true gdy wszystkie 4 pionki któregoś gracza będą na polach końcowych
		return base.glownaPetlaRozgrywki();
	}
}