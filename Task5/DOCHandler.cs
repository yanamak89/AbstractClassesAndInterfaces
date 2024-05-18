namespace AbstractClassesAndInterfaces;

public class DOCHandler : AbstractHandler
{
    public override void Open()
    {
        Console.WriteLine("You open DOC document");
    }

    public override void Create()
    {
        Console.WriteLine("You create DOC document");
    }

    public override void Change()
    {
        Console.WriteLine("You change DOC document");
    }

    public override void Save()
    {
        Console.WriteLine("You save DOC document");

    }
}