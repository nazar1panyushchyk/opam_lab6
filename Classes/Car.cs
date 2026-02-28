using LabPolymorphism;

class Car : Vehicle, IRefuelable
{
    public Car(string brand, int speed) : base(brand, speed) { }

    public override void Move()
    {
        Console.WriteLine($"Автомобіль {Brand} їде зі швидкістю {Speed} км/год.");
    }

    public void Refill()
    {
        Console.WriteLine($"Автомобіль {Brand} заправляється паливом.");
    }
}