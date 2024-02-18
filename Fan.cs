

namespace BaseballSimulator;

class Fan
{
    public Fan(Ball ball) => ball.BallInPlay += BallInPlayEventHandler;
    private int pitchNumber = 0;
    private void BallInPlayEventHandler(object? sender, BallEventArgs e)
    {
        pitchNumber++;
        if (e.Distance > 400 && e.Angle > 30)
            System.Console.WriteLine($"Pitch #{pitchNumber}: Home run! I'm going for the ball.");
        else
            System.Console.WriteLine($"Pitch #{pitchNumber}: Woo ho hoooo... Yeah baby!!");
    }
}
