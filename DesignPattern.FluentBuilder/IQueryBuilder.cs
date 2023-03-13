namespace DesignPattern.FluentBuilder
{
    public interface ISelectBuilder
    {
        IFromBuilder Select();
    }

    public interface IFromBuilder
    {
        IWhereBuilder From(string tableName);
    }

    public interface IWhereBuilder
    {
        IQueryBuilder Where(string column, string value);
        string Build();
    }

    public interface IQueryBuilder
    {
        string Build();
    }
}
