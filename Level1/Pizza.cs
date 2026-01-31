namespace MainProgram.Level1;

public class Pizza
{
    public string Dough { get; set; }

    public string Sauce { get; set; }

    public bool HasCheese { get; set; }

    public bool HasPepperoni { get; set; }

    public bool HasMushrooms { get; set; }

    public override string ToString()
    {
        return $"Dough: {Dough} | Sauce: {Sauce} | Cheese: {HasCheese} | Pepperoni: {HasPepperoni} | Mushrooms: {HasMushrooms}";
    }
}
