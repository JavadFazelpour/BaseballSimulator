namespace BaseballSimulator;
delegate void BatCallback(BallEventArgs e);
class Bat
{
    private BatCallback hitBallCallback;
    public Bat(BatCallback callbackDelegate) => this.hitBallCallback = callbackDelegate;
    public void HitTheBall(BallEventArgs e) => hitBallCallback?.Invoke(e);
}
