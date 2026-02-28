using System;

class Airplane : Vehicle, IRefuelable
{
    public Airplane(string brand, int speed) : base(brand, speed) { }

    public override void Move()
    {
        Console.WriteLine($"Літак {Brand} летить зі швидкістю {Speed} км/год.");
    }

    public void Refill()
    {
        Console.WriteLine($"Літак {Brand} заправляється авіаційним паливом.");
    }
}