namespace Task3;

public class Player : IPlayable, IRecodable
{
    void IPlayable.Play()
    {
        Console.WriteLine("Playing ... ");
    }
    
    void IRecodable.Record()
    {
        Console.WriteLine("Recording ... ");
    }
    public void Pause()
    {
        Console.WriteLine("Pausing ... ");
    }
    public void Stop()
    {
        Console.WriteLine("Stoping ... ");
    }
    
}