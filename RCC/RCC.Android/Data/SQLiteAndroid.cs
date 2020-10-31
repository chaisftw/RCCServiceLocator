using SQLite;
using Xamarin.Forms;
using RCC.Data;
using RCC.Droid.Data;
using System.IO;
[assembly: Dependency(typeof(SQLiteAndroid))]

/// <summary>
/// This dependancy service inherits the SQLite interface (RCC.Data.ISQLite.cs)
/// </summary>
namespace RCC.Droid.Data
{
    public class SQLiteAndroid : ISQLite
    {

        public SQLiteAndroid() { }

        /// <summary>
        /// Connects to the local database
        /// </summary>
        /// <returns>SQLiteConnection</returns>
        public SQLiteConnection GetConnection()
        {
            var fileName = "locationDatabase.db3";
            string documentsPath = System.Environment.GetFolderPath(System.Environment.SpecialFolder.MyDocuments);
            var path = Path.Combine(documentsPath, fileName);

            var con = new SQLite.SQLiteConnection(path);
            return con;
        }

    }
}