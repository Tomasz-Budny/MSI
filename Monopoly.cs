public class Monopoly : Gra
{
    private Dictionary<string, decimal> kontaBankowe = new(); // s�ownik trzymaj�cy ilo�� pieni�dzy ka�dego gracza
    private List<(string, decimal)> dost�pneNieruchomo�ci; // lista trzymaj�ca krotk� warto�ci - nazwa dost�pnej nieruchomo�ci oraz jej cena
    private int startowePieniadze;
    public Monopoly(string nazwa, float sredniCzasTrwania, int iloscGraczy) : base(nazwa, 8, sredniCzasTrwania)
    {
        foreach(var gracz in powi�zanaRozgrywka.gracze)
        {
            kontaBankowe.Add(gracz.pseudonim, startowePieniadze);
        }
    }
    public virtual void uzyjPodstawowychUstawien(){}
	public override bool glownaPetlaRozgrywki(Gracz gracz)
	{
		// obs�uguj� tur� gracza, gra si� ko�czy gdy zostanie jeden gracz nie-bankrut
		return base.glownaPetlaRozgrywki(gracz);
	}
}