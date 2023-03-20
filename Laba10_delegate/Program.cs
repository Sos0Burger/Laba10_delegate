using System.Collections;

internal class Program
{
    private static void Main(string[] args)
    {
        Garage garage = new Garage();
        garage.carList.Add(new Car("Крутая"));

        garage.carList.Add(new Car("Не очень крутая"));

        WasherDelegate washer = new Washer().wash;

        washer(garage.carList[0]);
        washer(garage.carList[1]);

    }
}
class Car
{
    public string Name { get; set; }

    public Car(string name)
    {
        Name = name;
    }
}
class Garage
{
    public List<Car> carList { get; set; }

    public Garage()
    {
        carList = new List<Car>();
    }
}
class Washer
{
    public void wash(Car car)
    {
        Console.WriteLine($"Машина {car.Name} помыта");
    }
}

delegate void WasherDelegate(Car car);