using RCC.Models;
using System;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Maps;
using Xamarin.Forms.Xaml;

namespace RCC
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LargeMap : ContentPage
    {
        private Map map;
        private Pin pin;
        private LocationModel location;

        public LargeMap()
        {
            InitializeComponent();
            Init();
        }

        private void Init()
        {
            var locationEnumerator = App.DBManager.GetDBLocations();

            // Find the selected location
            while (locationEnumerator.MoveNext())
            {
                if (locationEnumerator.Current.ID == Data.SelectionManager.GlobalLocationID)
                {
                    location = locationEnumerator.Current;
                    break;
                }
            }

            Position mapPos = new Position(location.Lat, location.Long); // Get the selected location's position

            // Initialise the map displaying the location
            map = new Map(MapSpan.FromCenterAndRadius(mapPos, Distance.FromKilometers(0.5)))
            {
                MapType = MapType.Street,
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

            // Add the pin to the map
            map.Pins.Add(pin);

            // Add the map to the grid layout
            mapLayout.Children.Add(map, 0, 0);

            // Set the title to the locations name
            this.Title = location.Name;
        }

        // Opens the devices default map app
        private void OpenMapsApp()
        {
            Device.OpenUri(new Uri("http://maps.google.com/maps?daddr=" + location.Lat + "," + location.Long));
        }
    }
}