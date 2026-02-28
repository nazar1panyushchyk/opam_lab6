using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        //task1
        List<Vehicle> vehicles = new List<Vehicle>
        {
            new Car("Toyota", 120),
            new Bicycle("Giant", 25),
            new Airplane("Boeing", 800)
        };

        foreach (Vehicle vehicle in vehicles)
        {
            vehicle.Move();
        }
        Console.WriteLine("=====================================================");

        //task2
        List<ChessPiece> pieces = new List<ChessPiece>
        {
            new King("White"),
            new Knight("Black"),
            new Pawn("White")
        };

        foreach (ChessPiece piece in pieces)
        {
            Console.WriteLine($"{piece.GetType().Name} може ходити з (4,4) у (5,5)? {piece.CanMove(4, 4, 5, 5)}");
        }
    }
}