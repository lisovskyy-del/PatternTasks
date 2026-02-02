namespace MainProgram.Level3;

class Menu
{
    public static void Task7()
    {
        Console.WriteLine("\nTask 7 start:\n");

        var director = new QueryDirector();
        var builder = new SqlBuilder();
        director.Builder = builder;

        Console.WriteLine("\nSimple user query:\n");
        director.MakeSimpleUserQuery();
        Console.WriteLine(builder.GetResult());

        Console.WriteLine("\nComplex report query:\n");
        director.MakeComplexReportQuery();
        Console.WriteLine(builder.GetResult());


        Console.WriteLine("\nTask 7 end\n");
    }

    public static void Run()
    {
        Task7();
    }
}
