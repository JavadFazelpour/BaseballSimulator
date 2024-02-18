namespace BaseballSimulator;

class BallEventArgs : EventArgs
{
    public int Distance { get; private set; }
    public int Angle { get; private set; }
    public BallEventArgs(int distance, int angle)
    {
        Distance = distance;
        Angle = angle;
    }
}
