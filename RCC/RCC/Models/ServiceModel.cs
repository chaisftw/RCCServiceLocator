using SQLite;

namespace RCC.Models
{
    /// <summary>
    /// This model has all of the fields required for each service row in the database
    /// </summary>
    public class ServiceModel
    {
        [PrimaryKey]
        [AutoIncrement]

        public int ID { get; set; }

        public int LocationID { get; set; } // Location foreign key

        public string Name { get; set; }
        public string ServiceType { get; set; }

        // Timetable fields
        public string Monday { get; set; }
        public string Tuesday { get; set; }
        public string Wednesday { get; set; }
        public string Thursday { get; set; }
        public string Friday { get; set; }
        public string Saturday { get; set; }
        public string Sunday { get; set; }
        
    }
}
