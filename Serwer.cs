class Serwer{
    public string lokalizacja;
    public int maksymalneObciazenie;
    public int aktualneObciazenie;
    public List<Serwer> rozgrywkiHostowane = new List<Serwer>();
    public List<Administrator> nadzorujący = new List<Administrator>();

    public static List<Serwer> serwery = new List<Serwer>();

    public static void Usun(Serwer serwer){}
    public static Serwer wybierzNajblizszySerwer(string kraj){
        //wybiera nabliższy serwer pod względem opóźnienia
        //argument kraj służy do zawężenia przeszukiwania
        return serwery[0];
    }
    public static void stworzSerwer(){}
    public void dodajRozgrywke(Rozgrywka rozgrywka) { }
}