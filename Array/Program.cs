Console.WriteLine("Programma stampa array 5x5");
int[,] array = new int[5,5];

int contatore = 0;


for(int i=0; i<5; i++){
    for(int j=0; j<5; j++){
        contatore++;
        if(j == 0){
            array[i,j] = 0;
        } else {
            array[i,j] = contatore;
        } 
    }
}

Console.WriteLine("Stampo l'array");
for(int i=0; i<5; i++){
    for(int j=0; j<5; j++){
        Console.Write(array[i,j] + " ");
    }
    Console.WriteLine();
}


