public class Organizzazione : IUtente {
    public string Id { get; set; }
    public int AnnoIscrizione { get; set; }
    public string RagioneSociale { get; set; }

    public string Denominazione { 
        get {
            return "Organizzazione: " + Id + " - " + RagioneSociale;
        }
     }

}