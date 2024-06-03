namespace AbstractClassesAndInterfaces;

public class TXTHandler : AbstractHandler
{
    public override void Open()
    {
        Console.WriteLine("You open TXT document");
    }

    public override void Create()
    {
        Console.WriteLine("You create TXT document");
    }

    public override void Change()
    {
        Console.WriteLine("You change TXT document");
    }

    public override void Save()
    {
        Console.WriteLine("You save TXT document");

    }
}