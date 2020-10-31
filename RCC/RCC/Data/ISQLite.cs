using SQLite;

namespace RCC.Data
{
    /// <summary>
    /// Interface for dependancy service
    /// </summary>
    public interface ISQLite
    {
        SQLiteConnection GetConnection();
    }
}
