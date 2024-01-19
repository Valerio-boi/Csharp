
    public class Persona{
        public string Nome { get; set; }
        public string Cognome  { get; set; }

         public virtual string Denominazione {
            get
            {
                return Nome + " " + Cognome;
            }
        }
    }
