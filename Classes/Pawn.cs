using System;

class Pawn : ChessPiece
{
    public Pawn(string color) : base(color) { }

    public override bool CanMove(int fromX, int fromY, int toX, int toY)
    {
        if (Color == "White")
        {
            return fromX == toX && toY - fromY == 1;
        }
        else
        {
            return fromX == toX && fromY - toY == 1;
        }
    }
}