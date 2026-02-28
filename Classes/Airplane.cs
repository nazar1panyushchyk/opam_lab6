using System;

class Airplane : Vehicle
{
    public Airplane(string brand, int speed) : base(brand, speed)
    {
    }

    public override void Move()
    {
        Console.WriteLine($"Літак {Brand} летить зі швидкістю {Speed} км/год.");
    }
}