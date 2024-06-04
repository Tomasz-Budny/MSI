using System.Dynamic;

public class Czat
{
    public List<Uzytkownik> uczestnicy = new List<Uzytkownik>();
    public List<Wiadomosc> wiadomości = new List<Wiadomosc>();

    public void wyślijWiadomość(Uzytkownik nadawca, string treść){

    }
    public void kasujWiadomość(Wiadomosc wiadomość){

    }
    public Wiadomosc[] szukajWHistorii(List<String> słowaKluczowe){
        //funkcja zwraca tablicę ze wszystkimi wiadomościami
        //zawierającymi podane słowa kluczowe

        return new Wiadomosc[1]; // tylko do zobrazowania
    }
    public void Usun(){
        // usuwa cały czat
    }
    public void dodajUczestnika(Uzytkownik uczestnik){
        // dodaje wskazaną osobę do rozmowy
        uczestnik.czaty.Add(this);
    }
}
