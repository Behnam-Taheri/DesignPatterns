namespace DesignPattern.SimpleBuilder
{
    public class QueryBuilder
    {
        private string query = "";

        public QueryBuilder Select()
        {
            query += "Select * ";
            return this;
        }

        public QueryBuilder From(string tableName)
        {
            query += $"From {tableName} ";
            return this;
        }

        public QueryBuilder Where(string column, string value)
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
