using SQLite;

namespace RCC.Models
{
    /// <summary>
    /// This model has all of the fields required for each location row in the database
    /// </summary>
    public class LocationModel
    {
        [PrimaryKey]
        [AutoIncrement]

        public int ID { get; set; }

        public string Name { get; set; }
        public string Suburb { get; set; }
        public string Icon { get; set; } // File name of the providers icon image
        public string Image { get; set; } // File name of the providers location image
        public string FacebookLink { get; set; }
        public string WebLink { get; set; }
        public string Phone { get; set; }

        // Geo coordinates
        public double Lat { get; set; }
        public double Long { get; set; }
    }
}
