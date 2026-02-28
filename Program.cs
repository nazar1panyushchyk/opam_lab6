using LabPolymorphism;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
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

        Console.WriteLine("=====================================================");
        
        //task3
        List<Artifact> inventory = new List<Artifact>();

        inventory.Add(new MagicScroll(101));
        inventory.Add(new AncientSword(202));

        Console.WriteLine("--- Аналіз інвентарю ---");

        foreach (var item in inventory)
        {
            item.Identify();
        }

        Console.WriteLine("\nНатисніть будь-яку клавішу для виходу...");
        Console.ReadKey();
    }
}