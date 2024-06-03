namespace AbstractClassesAndInterfaces;

public class XMLHandler : AbstractHandler
{
    public override void Open()
    {
        Console.WriteLine("You open XML document");
    }

    public override void Create()
    {
        Console.WriteLine("You create XML document");
    }

    public override void Change()
    {
        Console.WriteLine("You change XML document");
    }

    public override void Save()
    {
        Console.WriteLine("You save XML document");

    }
}