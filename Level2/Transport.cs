namespace MainProgram.Level2;

interface ITransport
{
    string Deliver();
}

class Truck : ITransport
{
    public string Deliver()
    {
        return "Truck operation";
    }
}

class Boat : ITransport
{
    public string Deliver()
    {
        return "Boat operation";
    }
}
