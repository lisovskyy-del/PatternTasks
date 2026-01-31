namespace MainProgram.Level1;

class Goverment
{
    private static Goverment _instance;

    private Goverment() { }

    public static Goverment GetInstance()
    {
        if (Goverment._instance == null)
        {
            _instance = new Goverment();
        }

        return _instance;
    }
}