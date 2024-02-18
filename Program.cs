namespace BaseballSimulator;
class Program
{
    static readonly Ball ball = new Ball();
    static readonly Pitcher pitcher = new Pitcher(ball);
    static readonly Fan fan = new Fan(ball);
    static void Main(string[] args)
    {
        var running = true;
        while (running)
        {
            System.Console.Write("Enter a number for distance, or anything else to quit. ");
            if (int.TryParse(Console.ReadLine(), out int distance))
            {
                System.Console.Write("\nEnter a number for angle, or anything else to quit: ");
                if (int.TryParse(Console.ReadLine(), out int angle))
                {
                    BallEventArgs e = new BallEventArgs(distance, angle);
                    ball.OnBallInPlay(e);
                }
                else running = false;
            }
            else running = false;
        }
        System.Console.WriteLine("Thanks for playing!");
    }
}
