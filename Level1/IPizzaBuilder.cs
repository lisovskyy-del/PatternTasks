namespace MainProgram.Level1;

public interface IPizzaBuilder
{
    IPizzaBuilder SetDough(string dough);

    IPizzaBuilder AddSauce(string sauce);

    IPizzaBuilder AddCheese(bool cheese);

    IPizzaBuilder AddPepperoni(bool pepperoni);

    IPizzaBuilder AddMushrooms(bool mushrooms);

    Pizza Build();
}