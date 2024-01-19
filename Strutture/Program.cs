namespace Strutture;

public class MyClass {

    public string myString;
    public int myInt;
}

public struct MyStruct {

    public string myString;
    public int myInt;
}

class Program
{
    static void Main(string[] args)
    {
        
        MyClass myClass = new MyClass();
        MyStruct myStruct = new MyStruct();
        myClass.myString = "Hello";
        myClass.myInt = 1;
        myStruct.myString = "Hellooo";
        myStruct.myInt = 2;

        Console.WriteLine($"Prima: {myClass.myString} {myClass.myInt}");
        Console.WriteLine($"Prima: {myStruct.myString} {myStruct.myInt}");

        MyMethod(myClass, myStruct, 20, "Ciaone");

        Console.WriteLine($"Dopo: {myClass.myString} {myClass.myInt}");
        Console.WriteLine($"Dopo: {myStruct.myString} {myStruct.myInt}");

    }

    public static void MyMethod(MyClass myClass, MyStruct myStruct, int myInt, string myString)
    {
        myClass.myString = myString;
        myClass.myInt = myInt;
        myStruct.myString = myString;
        myStruct.myInt = myInt;

    }
}
