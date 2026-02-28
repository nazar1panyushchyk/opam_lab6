using LabPolymorphism;

class King : ChessPiece
{
    public King(string color) : base(color) { }

    public override bool CanMove(int fromX, int fromY, int toX, int toY)
    {
        int dx = Math.Abs(toX - fromX);
        int dy = Math.Abs(toY - fromY);
        return dx <= 1 && dy <= 1;
    }
}