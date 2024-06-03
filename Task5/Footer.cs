namespace Task5;

public class Footer : DocumentPart
{
    public string Text { get; set; }

    public override void Render()
    {
        Console.WriteLine($"Footer: {Text}");
    }
}