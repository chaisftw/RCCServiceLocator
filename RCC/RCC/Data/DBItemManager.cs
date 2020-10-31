using RCC.Models;
using SQLite;
using System.Collections.Generic;
using Xamarin.Forms;

namespace RCC.Data
{
    /// <summary>
    /// Database control methods
    /// </summary>
    public class DBItemManager
    {
        private static object locker = new object();
        private SQLiteConnection database;

        public DBItemManager()
        {
            // Gets the devices local database and sets up the required tables
            this.database = DependencyService.Get<ISQLite>().GetConnection();
            this.database.CreateTable<LocationModel>();
            this.database.CreateTable<ServiceModel>();
        }

        /// <summary>
        /// Puts every location into an enumerator
        /// </summary>
        /// <returns>Enumerator with all of the locations in the database</returns>
        public IEnumerator<LocationModel> GetDBLocations()
        {
            lock(locker)
            {
                if(this.database.Table<LocationModel>().Count() == 0)
                {
                    return null;
                }
                else
                {
                    return this.database.Table<LocationModel>().GetEnumerator();
                }
                    
            }
        }

        /// <summary>
        /// Updates a location if it exists or Saves a new location to the database
        /// </summary>
        /// <param name="item"></param>
        /// <returns>The number of rows added to the database table</returns>
        public int SaveDBLocation(LocationModel item)
        {
            lock (locker)
            {
                if(item.ID != 0)
                {
                    this.database.Update(item);
                    return item.ID;
                }
                else
                {
                    return this.database.Insert(item);
                }
            }
        }

        /// <summary>
        /// Deletes a location from the database by ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns>The number of rows deleted from the database table</returns>
        public int DeleteDBLocation(int id)
        {
            lock (locker)
            {
                return this.database.Delete<LocationModel>(id);
            }
        }

        /// <summary>
        /// Puts every service into an enumerator
        /// </summary>
        /// <returns>An enumerator with every services in the database</returns>
        public IEnumerator<ServiceModel> GetDBServices()
        {
            lock (locker)
            {
                if (this.database.Table<ServiceModel>().Count() == 0)
                {
                    return null;
                }
                else
                {
                    return this.database.Table<ServiceModel>().GetEnumerator();
                }

            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="item"></param>
        /// <returns>The number of rows added to the database table</returns>
        public int SaveDBService(ServiceModel item)
        {
            lock (locker)
            {
                if (item.ID != 0)
                {
                    this.database.Update(item);
                    return item.ID;
                }
                else
                {
                    return this.database.Insert(item);
                }
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns>The number of rows deleted from the database table</returns>
        public int DeleteDBService(int id)
        {
            lock (locker)
            {
                return this.database.Delete<ServiceModel>(id);
            }
        }

    }
}
