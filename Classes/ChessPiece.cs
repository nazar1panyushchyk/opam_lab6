using LabPolymorphism;

abstract class ChessPiece
{
    public string Color { get; set; }

    public ChessPiece(string color)
    {
        Color = color;
    }

    public abstract bool CanMove(int fromX, int fromY, int toX, int toY);
}