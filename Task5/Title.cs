namespace Task5;

public class Title : DocumentPart
{
    public string Text { get; set; }

    public override void Render()
    {
        Console.WriteLine($"Title: {Text}");
    }
}