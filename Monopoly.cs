public class Monopoly : Gra
{
    private Dictionary<string, decimal> kontaBankowe = new(); // s³ownik trzymaj¹cy iloœæ pieniêdzy ka¿dego gracza
    private List<(string, decimal)> dostêpneNieruchomoœci; // lista trzymaj¹ca krotkê wartoœci - nazwa dostêpnej nieruchomoœci oraz jej cena
    private int startowePieniadze;
    public Monopoly(string nazwa, float sredniCzasTrwania, int iloscGraczy) : base(nazwa, 8, sredniCzasTrwania)
    {
        foreach(var gracz in powi¹zanaRozgrywka.gracze)
        {
            kontaBankowe.Add(gracz.pseudonim, startowePieniadze);
        }
    }
    public virtual void uzyjPodstawowychUstawien(){}
	public override bool glownaPetlaRozgrywki(Gracz gracz)
	{
		// obs³ugujê turê gracza, gra siê koñczy gdy zostanie jeden gracz nie-bankrut
		return base.glownaPetlaRozgrywki(gracz);
	}
}