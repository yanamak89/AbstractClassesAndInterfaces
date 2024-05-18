using Task3;

class Program
{
    static void Main(string[] arg)
    {
        Player player = new Player();
        
        Console.WriteLine("Playback Operations:");
        ((IPlayable)player).Play();
        player.Pause();
        player.Stop();
        
        Console.WriteLine("\nRecording Operations:");
        ((IRecodable)player).Record();
        player.Pause();
        player.Stop();
    }
}