using System.Reflection.Metadata;
using AbstractClassesAndInterfaces;
using Task5;

class Program
{
    static void Main(string[] args)
    {
        // Creating parts of the document
        DocumentPart title = new Title { Text = "Abstract Class Example" };
        DocumentPart body = new Body { Text = "his is an example of using abstract class for document parts." };
        DocumentPart footerv = new Footer { Text = "End of the document" };
        
        // Rendering the document parts
        title.Render();
        body.Render();
        footerv.Render();
        
        // Creating instances of different document handlers
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