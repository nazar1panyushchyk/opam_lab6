using System;

class Car : Vehicle
{
    public Car(string brand, int speed) : base(brand, speed)
    {
    }

    public override void Move()
    {
        Console.WriteLine($"Автомобіль {Brand} їде зі швидкістю {Speed} км/год.");
    }
}