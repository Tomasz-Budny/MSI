using System.Security.Cryptography;

public class ProsbaDolaczenia
{
    private int czasWygasniecia = 60;
    public string nazwaRozgrywki;
    Gracz gracz;
    Rozgrywka rozgrywka;

    public bool sprawdzHaslo(string haslo){
        //sprawdza czy podane hasło zgadza się z hasłem rozgrywki
        return rozgrywka.SprawdźHasło(haslo);
    }
    public void dolacz(){
        // dołącza gracza do lobby rozgrywki
        rozgrywka.gracze.Add(gracz);
    }
}