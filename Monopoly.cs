public class Monopoly : Gra
{
    private List<int> kontaBankowe = new List<int>();
    private int startowePieniadze;
    public Monopoly(string nazwa, float sredniCzasTrwania, int iloscGraczy) : base(nazwa, 8, sredniCzasTrwania)
    {
        for(int i = 0; i< iloscGraczy; i++){
            kontaBankowe.Add(startowePieniadze);
        }
    }
    public virtual void uzyjPodstawowychUstawien(){}
	public override bool glownaPetlaRozgrywki()
	{
		// obs�uguj� tur� gracza, gra si� ko�czy gdy zostanie jeden gracz nie-bankrut
		return base.glownaPetlaRozgrywki();
	}
}