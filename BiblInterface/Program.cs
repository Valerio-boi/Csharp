namespace BiblInterface;

class Program
{
    public static IUtente [] utenti = new IUtente[2];
    static void Main(string[] args)
    {
       Persona p = new Persona(){Id = "1", AnnoIscrizione = 2019, Nome = "Mario", Cognome = "Rossi"};
       Organizzazione o = new Organizzazione(){Id = "2", AnnoIscrizione = 2019, RagioneSociale = "Societa' srl"};
       utenti[0] = p;
       utenti[1] = o;
       stampaUtente();
    }

    public static void stampaUtente()
    {
        Console.WriteLine("Utenti registrati:");
        foreach (IUtente u in utenti)
        {
            Console.WriteLine(u.Denominazione);
        }
    }
}
