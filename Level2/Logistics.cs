namespace MainProgram.Level2;

abstract class Logistics
{
    public abstract ITransport CreateTransport();

    public string SomeOperation()
    {
        var product = CreateTransport();

        var result = $"Creator: The same creator's code has just worked with {product.Deliver()}";

        return result;
    }
}

class TruckLogistics : Logistics
{
    public override ITransport CreateTransport()
    {
        return new Truck();
    }
}

class SeaLogistics : Logistics
{
    public override ITransport CreateTransport()
    {
        return new Boat();
    }
}
