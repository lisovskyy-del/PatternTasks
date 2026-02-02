namespace MainProgram.Level3;

class QueryDirector
{
    private ISqlBuilder _builder;

    public ISqlBuilder Builder
    {
        set { _builder = value; }
    }

    public void MakeSimpleUserQuery()
    {
        this._builder.Reset();
        this._builder.Select();
        this._builder.From();
    }

    public void MakeComplexReportQuery()
    {
        this._builder.Reset();
        this._builder.Select();
        this._builder.From();
        this._builder.Where();
        this._builder.Limit(5);
    }
}
