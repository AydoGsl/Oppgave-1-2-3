namespace Oppgave2;
using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Variabel av datatypen Int
        int myInteger = 42;
        Console.WriteLine($"Verdien av myInteger er: {myInteger}");

        // Variabel av datatypen string
        string myString = "Hello Kodehode";
        Console.WriteLine($"Verdien av myString er: {myString}");

        // Variabel av datatypen double

        double myDouble = 420.69;
        Console.WriteLine($"Verdien av myDouble er: {myDouble}");

        // Variabel av datatypen char

        char myChar = 'A';
        Console.WriteLine($"Verdien av myChar er: {myChar}");

        // Array av datatypen int og skriv ut verdiene med vanlig for-løkke

        int[] intArray = { 6, 2, 1, 8, 7};
        Console.WriteLine("Dette er tall");
        for (int i = 0; i < intArray.Length; i++)
        {
            Console.WriteLine(intArray[i]);
        }

        //Array av datatypen string og skriv ut verdiene med en foreach-løkke

        string[] stringArray = {"Du", "er", "teit"};
        Console.WriteLine("\nInnhold i stringArray:");
        foreach (string str in stringArray)
        {
            Console.WriteLine(str);
        }

        // List av datatypen string og legg til verdier
        
        List<string> myStringList = new List<string>();
        myStringList.Add("Første potet");
        myStringList.Add("Andre Potet");
        myStringList.Add("Tredje Potet");

        //Skriv ut verdiene i listen med en foreach-løkke

        Console.WriteLine("\nInnhold i myStringList:");
        foreach (string item in myStringList)
        {
            Console.WriteLine(item);
        }
        

    }
}
