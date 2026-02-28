using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
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
    }
}