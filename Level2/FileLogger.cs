namespace MainProgram.Level2;

public sealed class FileLogger
{
    private static readonly Lazy<FileLogger> _instance = new Lazy<FileLogger>(() => new FileLogger());

    private readonly string _filePath = "log.txt";

    private FileLogger()
    {
        File.AppendAllText(_filePath, "Logger created\n");
    }

    public static FileLogger Instance => _instance.Value;

    public void Log(string message)
    {
        lock (_instance)
        {
            File.AppendAllText(_filePath, message);
        }
    }
}
