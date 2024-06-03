namespace Task5;

// Concrete class for Body part
public class Body : DocumentPart
{
    public string Text { get; set; }

    public override void Render()
    {
        Console.WriteLine($"Body: {Text}");
    }
}