namespace BaseballSimulator;
class Pitcher
{
    public Pitcher(Ball ball) => ball.BallInPlay += BallInPlayEventHandler;
    private int pitchNumber = 0;
    private void BallInPlayEventHandler(object? sender, BallEventArgs e)
    {
        pitchNumber++;
        if (e.Distance < 95 && e.Angle < 60)
            System.Console.WriteLine($"Pitch #{pitchNumber}: I cought the ball.");
        else
            System.Console.WriteLine($"Pitch #{pitchNumber}: I covered the first base");
    }
}
