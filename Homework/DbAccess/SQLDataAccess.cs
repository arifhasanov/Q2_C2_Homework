namespace Homework.DbAccess;

public class SQLDataAccess
{
    public string? ConnectionString { get; private set; }
    public SQLDataAccess(string? connectionString)
    {
        ConnectionString = connectionString;
    }
}
