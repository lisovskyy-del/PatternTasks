namespace MainProgram.Level3;

class SqlBuilder : ISqlBuilder
{
    string Result { get; set; }

    public void Reset()
    {
        Result = string.Empty;
    }

    public ISqlBuilder Select()
    {
        Result += "SELECT ";
        return this;
    }

    public ISqlBuilder From()
    {
        Result += "FROM table ";
        return this;
    }

    public ISqlBuilder Where()
    {
        Result += "WHERE ";
        return this;
    }

    public ISqlBuilder Limit(int limit)
    {
        Result += $"LIMIT {limit}";
        return this;
    }

    public string GetResult()
    {
        return Result;
    }
}
