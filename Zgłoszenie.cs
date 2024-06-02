public class Zgłoszenie
{
    private string treśćZgłoszenia;
    private string pseudonimZgłaszanegoGraza;
    private Rodzaj rodzajZgłoszenia = Rodzaj.Inne;
    private Gracz zgłaszający;
    private List<Administrator> nadzorujący = new List<Administrator>();

    static List<Zgłoszenie> zgłoszenia;

    public static void DodajZgłoszenie(Zgłoszenie zgłoszenie)
    {
        zgłoszenia.Add(zgłoszenie);
    }

}

enum Rodzaj{
    ObrazliwyJezyk, NiesportoweZachowanie,UzywanieOszustw,Inne
}