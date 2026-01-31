using System.Runtime;

namespace MainProgram.Level2;

class Menu
{
    public static void Task4()
    {
        Console.WriteLine("\nTask 4 start:\n");

        Task[] tasks = new Task[5];

        for (int i = 0; i < tasks.Length; i++)
        {
            int id = i;
            tasks[i] = Task.Run(() =>
            {
                FileLogger.Instance.Log($"Message from task {id}\n");
            });
        }

        Task.WaitAll(tasks);

        Console.WriteLine("\nTask 4 end");
    }

    public static void Task5()
    {
        Console.WriteLine("\nTask 5 start:\n");

        Console.WriteLine("\nApp: Launched with the Truck transport.");
        Client(new TruckLogistics());

        Console.WriteLine("");

        Console.WriteLine("\nApp: Launched with the Boat transport.");
        Client(new SeaLogistics());

        Console.WriteLine("\nTask 5 end");
    }

    public static void Task6()
    {
        Console.WriteLine("\nTask 6 start:\n");

        Developer d1 = new()
        {
            Age = 42,
            BirthDate = Convert.ToDateTime("1977-01-01"),
            Name = "Jack Daniels",
            IdInfo = new ProjectDetails(666)
        };

        Developer d2 = d1.DeepCopy();

        Console.WriteLine("\nOriginal values of d1, d2:\n");
        Console.WriteLine("Developer 1:\n");
        Display(d1);
        Console.WriteLine("Developer 2:\n");
        Display(d2);

        d1.Age = 32;
        d1.BirthDate = Convert.ToDateTime("1900-01-01");
        d1.Name = "Frank";
        d1.IdInfo.IdNumber = 7878;

        Console.WriteLine("\nValues of d1, d2 after d1 change:\n");
        Console.WriteLine("Developer 1:\n");
        Display(d1);
        Console.WriteLine("Developer 2:\n");
        Display(d2);

        Console.WriteLine("\nTask 6 end\n");
    }

    public static void Display(Developer d)
    {
        Console.WriteLine($"\nID: {d.IdInfo.IdNumber} | Name: {d.Name} | Age: {d.Age} | Birth: {d.BirthDate.Year}");
    }

    public static void Client(Logistics logistics)
    {
        Console.WriteLine($"Client: I'm not aware of the creator's class, but it still works.\n{logistics.SomeOperation()}");
    }

    public static void Run()
    {
        Task4();
        Task5();
        Task6();
    }
}
