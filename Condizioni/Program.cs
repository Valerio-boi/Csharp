

Console.WriteLine("Scrivi qualcosa: ");
string strConsole = Console.ReadLine();

 /*if( strConsole == "primo"){
    Console.WriteLine("Hai scritto primo");
}else if(strConsole == "secondo"){
    Console.WriteLine("Hai scritto secondo");
}else{
    Console.WriteLine($"Hai scritto: {strConsole}");
}*/



switch(strConsole) {

    case "primo":
        Console.WriteLine("Hai scritto primo");
        break;
    case "secondo":
        Console.WriteLine("Hai scritto secondo");
        break;
    default:
        Console.WriteLine($"Hai scritto: {strConsole}");
        break;
}