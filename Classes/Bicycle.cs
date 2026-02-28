using LabPolymorphism;

class Bicycle : Vehicle
{
    public Bicycle(string brand, int speed) : base(brand, speed)
    {
    }

    public override void Move()
    {
        Console.WriteLine($"Велосипед {Brand} рухається зі швидкістю {Speed} км/год.");
    }
}