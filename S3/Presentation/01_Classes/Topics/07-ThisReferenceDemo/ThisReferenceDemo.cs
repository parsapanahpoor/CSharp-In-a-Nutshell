namespace Chapter03_Classes;

public static class ThisReferenceDemo
{
    public static void Run()
    {
        Console.WriteLine("=== The this Reference: Fluent API Pattern ===\n");

        var builder = new QueryBuilder()
            .Select("Name")
            .Where("Active = 1")
            .OrderBy("CreatedAt");

        Console.WriteLine(builder.Build());

        Console.WriteLine("\n💡 KEY POINT: Returning 'this' enables method chaining (Fluent API)");
    }

    class QueryBuilder
    {
        private string _select;
        private string _where;
        private string _orderBy;

        public QueryBuilder Select(string fields)
        {
            _select = fields;
            return this; // Enable chaining
        }

        public QueryBuilder Where(string condition)
        {
            _where = condition;
            return this;
        }

        public QueryBuilder OrderBy(string field)
        {
            _orderBy = field;
            return this;
        }

        public string Build() => $"SELECT {_select} WHERE {_where} ORDER BY {_orderBy}";
    }
}
