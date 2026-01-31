namespace MainProgram.Level1;

public class PizzaBuilder : IPizzaBuilder
{
    private Pizza _pizza = new();

    public IPizzaBuilder SetDough(string dough)
    {
        _pizza.Dough = dough;
        return this;
    }

    public IPizzaBuilder AddSauce(string sauce)
    {
        _pizza.Sauce = sauce;
        return this;
    }

    public IPizzaBuilder AddCheese(bool cheese)
    {
        _pizza.HasCheese = cheese;
        return this;
    }

    public IPizzaBuilder AddPepperoni(bool pepperoni)
    {
        _pizza.HasPepperoni = pepperoni;
        return this;
    }

    public IPizzaBuilder AddMushrooms(bool mushrooms)
    {
        _pizza.HasMushrooms = mushrooms;
        return this;
    }

    public Pizza Build()
    {
        return _pizza;
    }
}