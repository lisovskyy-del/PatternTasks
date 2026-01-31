namespace MainProgram.Level1;

class Menu
{
    public static void Task1()
    {
        Console.WriteLine("\nTask 1 start:\n");

        Goverment g1 = Goverment.GetInstance();
        Goverment g2 = Goverment.GetInstance();

        if (g1 == g2)
        {
            Console.WriteLine("\nSingleton works, both goverments contain the same value.");
        }
        else
        {
            Console.WriteLine("\nSingleton didnt work! both goverments have different values!");
        }

        Console.WriteLine("\nTask 1 end\n");
    }

    public static void Task2()
    {
        Console.WriteLine("\nTask 2 start:\n");

        Sheep s1 = new Sheep();

        s1.Name = "Dolly";
        s1.Age = 17;

        Sheep s2 = s1.Clone();
        s2.Name = "Molly";

        Console.WriteLine("\nValues of Sheep 1 and sheep 2:\n");
        Console.WriteLine("\nSheep 1:");
        Display(s1);
        Console.WriteLine("\nSheep 2:");
        Display(s2);

        Console.WriteLine("\nTask 2 end\n");
    }

    public static void Display(Sheep s)
    {
        Console.WriteLine($"\nName: {s.Name}\nAge: {s.Age}");
    }

    public static void Task3()
    {
        Console.WriteLine("\nTask 3 start:\n");

        Pizza pizza = new PizzaBuilder()
            .SetDough("Cool dough")
            .AddSauce("Cool sauce")
            .AddCheese(true)
            .AddPepperoni(false)
            .AddMushrooms(true)
            .Build();

        Console.WriteLine(pizza);

        Console.WriteLine("\nTask 3 end\n");
    }

    public static void Run()
    {
        Task1();
        Task2();
        Task3();
    }
}