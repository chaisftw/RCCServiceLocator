using RCC.Models;
using RCC.Data;

namespace RCC
{
    /// <summary>
    /// For inserting default data into the database
    /// </summary>
    public static class DataInserter
    {
        // Inserts data into the database if the database is empty
        public static void Insert()
        {
            var locations = App.DBManager.GetDBLocations();
            var services = App.DBManager.GetDBServices();
            
            if (locations == null)
            {
                App.DBManager.SaveDBLocation(new LocationModel { ID = 0, Name = "Redland Commmunity Center", Suburb = "Capalaba", Lat = -27.5224569, Long = 153.1923369, Icon = "_rcc_logo.png", Image = "_rcc.png", FacebookLink = "https://www.facebook.com/red.mcleod.7?hc_ref=ARQdoujwapBmQ49RSaW7Ts4Usk4ZycuI0vuqlJhCR9EG0rgZN1Mzx2Djo7xJs2hvCZs&__xts__[0]=68.ARC0XgxmJ2lGwRbwEIHiwnhHIGPkuLGPNwSiy5OFUbTUPTg5EEFjGkLZT81H_6OIjRL6wm1RiyQFbsRnG1IfwI46KdgizWOzwqD63ccZPyIPuvgnyY6y2RjpxTdSP_ra-vWDaECKJkNB_MAF4riPk7ARFM6mOFrKb80UPr-QuqyUsIYMkJe_eiWlWM4QDzO3njpQd_4Ohq7iWrhwGcCgrVlPoSkr_v2layNhFoR8qQ&__tn__=lC-R", Phone = "675685685", WebLink = "www.youtube.com" });
                App.DBManager.SaveDBLocation(new LocationModel { ID = 0, Name = "Soup Kitchen", Suburb = "Capalaba", Lat = -27.50540532302589, Long = 153.08110032773436, Icon = "_soup.png", Image = "_kitch.png", FacebookLink = "https://www.facebook.com/HousingforQld/", Phone = "07 3034 9800" });
                App.DBManager.SaveDBLocation(new LocationModel { ID = 0, Name = "Salvation Army", Suburb = "Cleveland", Lat = -27.56385686356312, Long = 153.0440214703125, Icon = "_salvo.png", Image = "_opshop.png", FacebookLink = "https://www.facebook.com/BentleighBaysideSalvos/", Phone = "07 3824 5222", WebLink = "https://salvos.org.au/bayside/" });
                App.DBManager.SaveDBLocation(new LocationModel { ID = 0, Name = "Healthy Home Economics", Suburb = "Cleveland", Lat = -27.522325370720697, Long = 153.23515062523563, Icon = "_fruit.png", Image = "_homec.png", Phone = "1300 610 610", WebLink = "https://anglicaresq.org.au/" });
                App.DBManager.SaveDBLocation(new LocationModel { ID = 0, Name = "Capalaba Counselling", Suburb = "Capalaba", Lat = -27.473599510677648, Long = 153.18090563011845, Icon = "_mum.png", Image = "_couns.png" });
                App.DBManager.SaveDBLocation(new LocationModel { ID = 0, Name = "Metro Pharmacy", Suburb = "Redland Bay", Lat = -27.57102964866405, Long = 153.13902025414188, Icon = "_drugs.png", Image = "_pharma.png", WebLink = "https://www.qld.gov.au/housing/renting/rent-assistance/rentconnect" });
                App.DBManager.SaveDBLocation(new LocationModel { ID = 0, Name = "Employment Angels", Suburb = "Redland Bay", Lat = -27.527196770132804, Long = 153.04426317406376, Icon = "_jobber.png", Image = "_emp.png", WebLink = "https://www.facebook.com/safehavencommunity/" });
                App.DBManager.SaveDBLocation(new LocationModel { ID = 0, Name = "Redland Bay Park", Suburb = "Redland Bay", Lat = -27.607543678455027, Long = 153.1561863918372, Icon = "_grill.png", Image = "_park.png", Phone = "13 74 68" });
                App.DBManager.SaveDBLocation(new LocationModel { ID = 0, Name = "Centrelink", Suburb = "Redland Bay", Lat = -27.620929108575353, Long = 153.18571214867313, Icon = "_lifeline.png", Image = "_cenno.png" });
                App.DBManager.SaveDBLocation(new LocationModel { ID = 0, Name = "St Vincents de Paul", Suburb = "4/ 18 Moreton Bay Road, Capalaba Queensland 4157", Lat = -27.522672, Long = 153.1991751, Icon = "_vinny_icon.png", Image = "_vinny.png", FacebookLink = "https://www.facebook.com/vinniesqld/", Phone = "07 3823 2304", WebLink = "http://qld.vinnies.org.au/" });

            }

            if (services == null)
            {
                App.DBManager.SaveDBService(new ServiceModel { ID = 0, LocationID = 1, ServiceType = "food", Name = "Sandwich", Monday = "10-2", Tuesday = "-", Wednesday = "-", Thursday = "-", Friday = "-", Saturday = "10-2", Sunday = "10-2" });
                App.DBManager.SaveDBService(new ServiceModel { ID = 0, LocationID = 1, ServiceType = "food", Name = "Hot Dog", Monday = "-", Tuesday = "-", Wednesday = "11-2", Thursday = "10-1", Friday = "10-1", Saturday = "-", Sunday = "-" });
                App.DBManager.SaveDBService(new ServiceModel { ID = 0, LocationID = 1, ServiceType = "food", Name = "Burger", Monday = "10-2", Tuesday = "11-2", Wednesday = "11-2", Thursday = "-", Friday = "-", Saturday = "-", Sunday = "-" });
                App.DBManager.SaveDBService(new ServiceModel { ID = 0, LocationID = 1, ServiceType = "living", Name = "Clothes", Monday = "24/7", Tuesday = "24/7", Wednesday = "24/7", Thursday = "24/7", Friday = "24/7", Saturday = "24/7", Sunday = "24/7" });
                App.DBManager.SaveDBService(new ServiceModel { ID = 0, LocationID = 1, ServiceType = "lifeSkills", Name = "Family Help", Monday = "-", Tuesday = "10-3", Wednesday = "-", Thursday = "10-3", Friday = "10-3", Saturday = "-", Sunday = "-" });
                App.DBManager.SaveDBService(new ServiceModel { ID = 0, LocationID = 1, ServiceType = "health", Name = "Relief Pack", Monday = "8-3", Tuesday = "8-3", Wednesday = "8-3", Thursday = "8-3", Friday = "8-3", Saturday = "-", Sunday = "-" });
                App.DBManager.SaveDBService(new ServiceModel { ID = 0, LocationID = 1, ServiceType = "facility", Name = "Phone", Monday = "8-3", Tuesday = "8-3", Wednesday = "8-3", Thursday = "8-3", Friday = "8-3", Saturday = "-", Sunday = "-" });
                App.DBManager.SaveDBService(new ServiceModel { ID = 0, LocationID = 1, ServiceType = "facility", Name = "Toilet", Monday = "8-3", Tuesday = "8-3", Wednesday = "8-3", Thursday = "8-3", Friday = "8-3", Saturday = "-", Sunday = "-" });

                App.DBManager.SaveDBService(new ServiceModel { ID = 0, LocationID = 2, ServiceType = "food", Name = "Chicken", Monday = "12-5", Tuesday = "12-5", Wednesday = "12-5", Thursday = "-", Friday = "-", Saturday = "-", Sunday = "12-5" });
                App.DBManager.SaveDBService(new ServiceModel { ID = 0, LocationID = 2, ServiceType = "food", Name = "Beef", Monday = "-", Tuesday = "12-5", Wednesday = "12-5", Thursday = "12-5", Friday = "12-5", Saturday = "12-5", Sunday = "-" });
                App.DBManager.SaveDBService(new ServiceModel { ID = 0, LocationID = 2, ServiceType = "food", Name = "Fish", Monday = "12-5", Tuesday = "-", Wednesday = "-", Thursday = "12-5", Friday = "12-5", Saturday = "12-5", Sunday = "12-5" });

                App.DBManager.SaveDBService(new ServiceModel { ID = 0, LocationID = 3, ServiceType = "living", Name = "Clothes", Monday = "8-5", Tuesday = "8-5", Wednesday = "8-5", Thursday = "8-5", Friday = "8-5", Saturday = "-", Sunday = "-" });

                App.DBManager.SaveDBService(new ServiceModel { ID = 0, LocationID = 4, ServiceType = "lifeSkills", Name = "Free Courses", Monday = "-", Tuesday = "9-4", Wednesday = "9-4", Thursday = "9-4", Friday = "-", Saturday = "-", Sunday = "-" });

                App.DBManager.SaveDBService(new ServiceModel { ID = 0, LocationID = 5, ServiceType = "health", Name = "Open", Monday = "8-5", Tuesday = "8-5", Wednesday = "8-5", Thursday = "8-5", Friday = "8-5", Saturday = "-", Sunday = "-" });

                App.DBManager.SaveDBService(new ServiceModel { ID = 0, LocationID = 6, ServiceType = "health", Name = "Open", Monday = "8-5", Tuesday = "8-5", Wednesday = "8-5", Thursday = "8-5", Friday = "8-5", Saturday = "9-4", Sunday = "-" });

                App.DBManager.SaveDBService(new ServiceModel { ID = 0, LocationID = 7, ServiceType = "money", Name = "Open", Monday = "9-4", Tuesday = "9-4", Wednesday = "9-4", Thursday = "9-4", Friday = "9-4", Saturday = "-", Sunday = "-" });

                App.DBManager.SaveDBService(new ServiceModel { ID = 0, LocationID = 8, ServiceType = "facility", Name = "Public Toilet", Monday = "24/7", Tuesday = "24/7", Wednesday = "24/7", Thursday = "24/7", Friday = "24/7", Saturday = "24/7", Sunday = "24/7" });

                App.DBManager.SaveDBService(new ServiceModel { ID = 0, LocationID = 9, ServiceType = "money", Name = "Open", Monday = "8-5", Tuesday = "8-5", Wednesday = "8-5", Thursday = "8-5", Friday = "8-5", Saturday = "-", Sunday = "-" });
            }
            /*
            if (locations == null)
            {
                App.DBManager.SaveDBLocation(new LocationModel { ID = 0, Name = "InSync Youth Services", Suburb = "38 Middle Street, Cleveland", Lat = -27.5255012, Long = 153.2660707, Icon = "_ac_icon.png", Image = "_ac.png", FacebookLink = "", Phone = "1300 610 610", WebLink = "https://anglicaresq.org.au/" });
                App.DBManager.SaveDBLocation(new LocationModel { ID = 0, Name = "St Vincents de Paul", Suburb = "4/ 18 Moreton Bay Road, Capalaba Queensland 4157", Lat = -27.522672, Long = 153.1991751, Icon = "_vinny_icon.png", Image = "_vinny.png", FacebookLink = "https://www.facebook.com/vinniesqld/", Phone = "07 3823 2304", WebLink = "http://qld.vinnies.org.au/" });
                App.DBManager.SaveDBLocation(new LocationModel { ID = 0, Name = "Department of Housing", Suburb = "shop 3/8-12 Dollery Rd, Capalaba QLD 4157", Lat = -27.521787, Long = 153.191936, Icon = "_rc_icon.png", Image = "_house.png", FacebookLink = "https://www.facebook.com/HousingforQld/", Phone = "07 3034 9800", WebLink = "https://www.qld.gov.au/" });
                App.DBManager.SaveDBLocation(new LocationModel { ID = 0, Name = "QStars", Suburb = "29 Lorraine Street, Capalaba", Lat = -27.5224476, Long = 153.1922142, Icon = "_q_icon.png", Image = "_q.png", FacebookLink = "", Phone = "1300 744 263", WebLink = "https://qstars.org.au/" });
                App.DBManager.SaveDBLocation(new LocationModel { ID = 0, Name = "Salvos connect Bayside ", Suburb = "1-9 Macarthur St, Alexandra hills", Lat = -27.5260306, Long = 153.2361122, Icon = "_salvo_icon.png", Image = "_salvo.png", FacebookLink = "https://www.facebook.com/BentleighBaysideSalvos/", Phone = "07 3824 5222", WebLink = "https://salvos.org.au/bayside/" });
                App.DBManager.SaveDBLocation(new LocationModel { ID = 0, Name = "Mangrove Housing ", Suburb = "Stockland Complex, Shop 93, 90-91 Middle Street,  Cleveland 4163", Lat = -27.5253745, Long = 153.2688019, Icon = "_mgh_icon.png", Image = "_mgh.png", FacebookLink = "", Phone = "07 3893 3299", WebLink = "https://mangrovehousing.com.au/" });
                App.DBManager.SaveDBLocation(new LocationModel { ID = 0, Name = "Mangrove Housing ", Suburb = "6/70 Andrew Street, Wynnum Q 4178", Lat = -27.446894, Long = 153.1715236, Icon = "_mgh_icon.png", Image = "_mgh.png", FacebookLink = "https://www.facebook.com/mangrovehousing/", Phone = "07 3893 3299", WebLink = "https://mangrovehousing.com.au/" });
                App.DBManager.SaveDBLocation(new LocationModel { ID = 0, Name = "WINNAM Aboriginal and Torrest Strait Islander Corporation", Suburb = "2 / 124 Florence St, Wynnum ", Lat = -27.4448842, Long = 153.1724794, Icon = "_WAATI_icon.png", Image = "_WAATI.png", FacebookLink = "https://www.facebook.com/mangrovehousing/", Phone = "", WebLink = "" });
                App.DBManager.SaveDBLocation(new LocationModel { ID = 0, Name = "Babi Youth And Family Services ", Suburb = "34 Bay Terrace Wynnum ", Lat = -27.4416507, Long = 153.1720987, Icon = "_babi_icon.png", Image = "_babi.png", FacebookLink = "https://www.facebook.com/BABI-Youth-Family-Service-183698315041808/", Phone = "07 3393 4176", WebLink = "https://babi.org.au/" });
                App.DBManager.SaveDBLocation(new LocationModel { ID = 0, Name = "Safe Haven Communities", Suburb = "", Lat = 0, Long = 0, Icon = "_haven.png", Image = "_haven.png", FacebookLink = "https://www.facebook.com/safehavencommunity/", Phone = "1800 042 836", WebLink = "https://safehavencommunity.com.au/" });
                App.DBManager.SaveDBLocation(new LocationModel { ID = 0, Name = "Gateway Community Inc", Suburb = "1098 Wynnum Rd, Murarrie QLD 4172", Lat = -27.4694818, Long = 153.0976456, Icon = "_gate_icon.png", Image = "_gate.png", FacebookLink = "https://www.facebook.com/Gateway-Community-Group-Inc-568833786617967/", Phone = "07 3890 8122", WebLink = "http://www.gatewaycg.org.au/" });
                App.DBManager.SaveDBLocation(new LocationModel { ID = 0, Name = "Rent Connect", Suburb = "shop 3/8-12 Dollery Rd, Capalaba QLD 4157", Lat = -27.521787, Long = 153.0976456, Icon = "_rc_icon.png", Image = "_rentc.png", FacebookLink = "", Phone = "13 74 68", WebLink = "https://www.qld.gov.au/housing/renting/rent-assistance/rentconnect" });


            }

            if (services == null)
            {

            }*/
        }
    }
}
