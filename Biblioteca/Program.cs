namespace Biblioteca;
using System;

class Program
{
    static void Main(string[] args)
    {
        Utente utente = new Utente() {
            Id = "1",
            Nome = "Mario",
            Cognome = "Rossi",
            AnnoIscrizione = "2019"};
        Utente utente1 = new Utente() {
            Id = "2",
            Nome = "Luigi",
            Cognome = "Verdi",
            AnnoIscrizione = "2019"};
        Libro libro = new Libro("1", "Il signore degli anelli", "Tolkien");

        libro.prestito(utente);
        libro.prestito(utente1);
        libro.restituzione();
        libro.prestito(utente1);
        Console.WriteLine(utente.Denominazione);
    }
}
