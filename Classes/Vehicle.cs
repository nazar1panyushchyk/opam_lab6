using LabPolymorphism;
using System.Collections.Generic;

abstract class Vehicle
{
    public string Brand { get; set; }
    public int Speed { get; set; }

    public Vehicle(string brand, int speed)
    {
        Brand = brand;
        Speed = speed;
    }

    public abstract void Move();
}