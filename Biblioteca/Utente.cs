
    public class Utente : Persona
    {
        public string Id { get; set; }
        public string AnnoIscrizione { get; set; }


        public override string Denominazione {
            get
            {
                return Id + " " + Nome + " " + Cognome;
            }
        }
    }
