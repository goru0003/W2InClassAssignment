namespace W2InClassAssignment;

public class Car
{
    public string Model { get; set; }
    public Engine Engine { get; set; }

    public Car(string model, Engine engine)
    {
        Model = model;
        Engine = engine;
    }

    public void Describe()
    {
        Console.WriteLine($"Model: {Model}");
        Console.WriteLine($"Engine Horsepower: {Engine.HorsePower}");
    }
}