using System;
using AbstractClassesAndInterfaces;

class Program
{
    static void Main(string[] arg)
    {
        AbstractHandler docHandler = new DOCHandler();
        AbstractHandler txtHandler = new TXTHandler();
        AbstractHandler xmlHandler = new XMLHandler();

        Console.WriteLine($"XML Document Operations: ");
        xmlHandler.Open();
        xmlHandler.Create();
        xmlHandler.Change();
        xmlHandler.Save();
        
        Console.WriteLine($"\nDOC Document Operations: ");
        docHandler.Open();
        docHandler.Create();
        docHandler.Change();
        docHandler.Save();
        
        Console.WriteLine($"\nTXT Document Operations: ");
        txtHandler.Open();
        txtHandler.Create();
        txtHandler.Change();
        txtHandler.Save();
        
        Console.ReadLine();
    }
}