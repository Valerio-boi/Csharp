

while(true){

    Console.WriteLine("Digita quante righe vuoi visualizzare? Scrivi no se vuoi concludere");
    string nRighe = Console.ReadLine();

    if(nRighe == "no") {
        Console.WriteLine("Esco dal ciclo infinito");
        break;
    }else{
        int numeroRighe = Convert.ToInt32(nRighe);
        string riga = "";
        for(int i=0; i<numeroRighe; i++){
            riga += "*";
            Console.WriteLine(riga);
        }
    }


}
