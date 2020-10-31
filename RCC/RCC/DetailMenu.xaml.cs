using RCC.Models;
using RCC.Data;
using System.Collections.ObjectModel;
using Xamarin.Forms;
using Xamarin.Forms.Maps;
using Xamarin.Forms.Xaml;
using System;

namespace RCC
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class DetailMenu : ContentPage
	{
        private ObservableCollection<ServiceModel> items = new ObservableCollection<ServiceModel>();
        private LocationModel location;

        
        private Uri uriDummy; // Variable for temporarily holding a uri for validation purposes

        private Color listColor;
        private Map map;
        private Pin pin;

        public DetailMenu()
        {
            InitializeComponent();
            Init();
        }

        private void Init()
        {
            var locationEnumerator = App.DBManager.GetDBLocations();
            var serviceEnumerator = App.DBManager.GetDBServices();

            // Change the theme colour of the app based on selected service type
            if (Data.SelectionManager.GlobalServiceType == "food")
            {
                listColor = Color.FromHex("#FF592E");
            }
            else if (Data.SelectionManager.GlobalServiceType == "living")
            {
                listColor = Color.FromHex("#FFCA1C");
            }
            else if (Data.SelectionManager.GlobalServiceType == "lifeSkills")
            {
                listColor = Color.FromHex("#00FF4C");
            }
            else if (Data.SelectionManager.GlobalServiceType == "health")
            {
                listColor = Color.FromHex("#63F200");
            }
            else if (Data.SelectionManager.GlobalServiceType == "money")
            {
                listColor = Color.FromHex("#A300EF");
            }
            else
            {
                listColor = Color.FromHex("#3A35EA");
            }

            // Find the currently selected location
            while (locationEnumerator.MoveNext())
            {
                if (locationEnumerator.Current.ID == Data.SelectionManager.GlobalLocationID)
                {
                    location = locationEnumerator.Current;
                    break;
                }
            }

            // Find services belonging to the selected location that are also of the selected service type
            while (serviceEnumerator.MoveNext())
            {
                if(serviceEnumerator.Current.LocationID == Data.SelectionManager.GlobalLocationID)
                {
                    if (serviceEnumerator.Current.ServiceType == Data.SelectionManager.GlobalServiceType)
                    {
                        this.items.Add(serviceEnumerator.Current);
                    }
                }
            }

            Position mapPos = new Position(location.Lat, location.Long); // Get the selected location's position 

            // Initialise the map displaying the location
            map = new Map(MapSpan.FromCenterAndRadius(mapPos, Distance.FromKilometers(0.5)))
            {
                IsShowingUser = false,
                VerticalOptions = LayoutOptions.FillAndExpand
            };

            // Pin the location
            pin = new Pin
            {
                Type = PinType.Place,
                Position = mapPos,
                Label = location.Name
            };
            
            // Try/catch incase the uri is invalid
            try
            {
                uriDummy = new Uri(location.WebLink);
            }
            catch (Exception)
            {
                // Hide the button if invalid
                webButton.IsVisible = false;
                webImage.IsVisible = false;
            }

            // If the location has a contact phone number...
            if(location.Phone != null)
            {
                // Try/catch incase the uri is invalid
                try
                {
                    uriDummy = new Uri("tel:" + location.Phone);
                }
                catch (Exception)
                {
                    // Hide the button if invalid
                    phoneButton.IsVisible = false;
                    phoneImage.IsVisible = false;
                }
            }
            else
            {
                // Hide the button if null
                phoneButton.IsVisible = false;
                phoneImage.IsVisible = false;
            }

            // Try/catch incase the uri is invalid
            try
            {
                uriDummy = new Uri(location.FacebookLink);
            }
            catch (Exception)
            {
                // Hide the button if invalid
                fbButton.IsVisible = false;
                fbImage.IsVisible = false;
            }

            // Add the pin to the map
            map.Pins.Add(pin);

            // Add the map to the grid layout
            visualRow.Children.Add(map, 1, 0);

            // Set the title to the locations name
            this.Title = location.Name;

            // Set image and colour
            locationImage.Source = location.Image;
            header.BackgroundColor = listColor;

            // Set datasource of detail menu timetable
            itemList.ItemsSource = this.items;
        }

        // Opens the devices phone dialer with the phone number automatically entered
        private void CallProvider()
        {
            Device.OpenUri(new Uri("tel:" + location.Phone));
        }

        // Opens the phone's internet browser with the web page displayed
        private void OpenWeb()
        {
            Uri uri = new Uri(location.WebLink);
            Device.OpenUri(new Uri(location.WebLink));
        }

        // Opens the phone's internet browser with the web page displayed
        private void OpenFB()
        {
            Device.OpenUri(new Uri(location.FacebookLink));
        }
    }
}