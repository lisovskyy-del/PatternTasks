namespace MainProgram.Level1;

class Sheep
{
    public string Name { get; set; }
    public int Age { get; set; }

    public Sheep Clone()
    {
        return (Sheep)this.MemberwiseClone();
    }
}
