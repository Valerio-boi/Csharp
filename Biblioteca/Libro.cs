public class Libro {

private string id;
private string titolo;
private string autore;
private Utente utente;

public Libro(string id, string titolo, string autore) {
    this.id = id;
    this.titolo = titolo;
    this.autore = autore;
}


public string descrizione(){
    return $"{titolo} di {autore}";
}

public void prestito(Utente utente){
    if(this.utente != null){
        Console.WriteLine("Libro già in prestito");
        return;
    }
    this.utente = utente;
}

public void restituzione(){
    this.utente = null;
}

}