namespace MainProgram.Level3;

interface ISqlBuilder
{
    void Reset();

    ISqlBuilder Select();

    ISqlBuilder From();

    ISqlBuilder Where();

    ISqlBuilder Limit(int limit);

    string GetResult();
}
