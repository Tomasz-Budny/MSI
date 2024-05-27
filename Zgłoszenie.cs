public class Zgłoszenie
{
    private string treśćZgłoszenia;
    private string pseudonimZgłaszanegoGraza;
    private Rodzaj rodzajZgłoszenia = Rodzaj.Inne;
    private Gracz zgłaszający;
    private List<Administrator> nadzorujący = new List<Administrator>();
    
}

enum Rodzaj{
    ObrazliwyJezyk, NiesportoweZachowanie,UzywanieOszustw,Inne
}