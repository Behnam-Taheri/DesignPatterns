namespace DesignPattern.FluentBuilder
{
    public class QueryBuilder : ISelectBuilder,
                                IFromBuilder,
                                IWhereBuilder,
                                IQueryBuilder
    {
        private string query = "";

        public IFromBuilder Select()
        {
            query += "Select * ";
            return this;
        }

        public IWhereBuilder From(string tableName)
        {
            query += $"From {tableName} ";
            return this;
        }

        public IQueryBuilder Where(string column, string value)
        {
            query += $"where {column} = {value}";
            return this;
        }

        public string Build()
        {
            return query;
        }
    }
}
