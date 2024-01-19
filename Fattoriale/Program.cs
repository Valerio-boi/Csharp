namespace Fattoriale;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Inserisci un numero intero positivo: ");
        int n = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"il fattoriale di {n} è: {fattoriale(n)}");
    }

    static int fattoriale(int n){
        if(n == 0)
            return 1;
        else
            return n * fattoriale(n-1);
    }
}
