public class ProśbaOOdblokowanie
{
    public Gracz gracz { get; private set; }
    string treśćProśby;

    static List<ProśbaOOdblokowanie> prośby;

    public static List<ProśbaOOdblokowanie> PrzeglądajWszystkieProśby()
    {
        return prośby;
    }

    public static ProśbaOOdblokowanie WyszukajProśbe(Gracz gracz, string treść)
    {
        // wyszukuje po graczu lub po treśvi prośby
        return prośby.First();
    }

    public static void UsuńProśbe(ProśbaOOdblokowanie prośba)
    {
        // usuwa prośbe z listy
    }

    public static void Dodaj(ProśbaOOdblokowanie prośba)
    {
        // Dodaje nową prośbe do listy
    }
}
