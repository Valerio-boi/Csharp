namespace ContentString;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Ciao inseirisci una stringa");
        string primaStringa = "Piciaopl";
        string secondaStringa = "ciao";
        
        string confronto ="";

        for(int i=0; i<primaStringa.Length; i++){
            int cont = 0;
            for(int e=i; cont<secondaStringa.Length; e++){
                cont++;
                confronto += primaStringa[e];
            }
            
            if(confronto == secondaStringa){
                Console.WriteLine("La stringa è presente");
                break;
            }            
             confronto ="";
        }
    }
}
