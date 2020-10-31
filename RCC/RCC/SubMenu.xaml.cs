using RCC.Models;
using RCC.Data;
using System.Collections.ObjectModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace RCC
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SubMenu : ContentPage
    {
        private ObservableCollection<LocationModel> items = new ObservableCollection<LocationModel>();

        private Color listColor;

        public SubMenu()
        {
            InitializeComponent();
            Init();
        }

        private void Init()
        {
            var locationEnumerator = App.DBManager.GetDBLocations();
            var serviceEnumerator = App.DBManager.GetDBServices();

            // Get all locations that have services related to the selected service type and add them to the list
            while (locationEnumerator.MoveNext())
            {
                while (serviceEnumerator.MoveNext())
                {
                    if(locationEnumerator.Current.ID == serviceEnumerator.Current.LocationID)
                    {
                        if(serviceEnumerator.Current.ServiceType == Data.SelectionManager.GlobalServiceType)
                        {
                            this.items.Add(locationEnumerator.Current);
                            break;
                        }
                    }
                }
                serviceEnumerator.Reset();
            }

            locationEnumerator.Reset();

            // Set datasource of sub menu list
            itemList.ItemsSource = this.items;

            SubMenuSetup();
        }

        /// <summary>
        /// Change the title and theme colour of the app based on selected service type
        /// </summary>
        private void SubMenuSetup()
        {
            food.IsVisible = false;
            living.IsVisible = false;
            lifeSkills.IsVisible = false;
            health.IsVisible = false;
            money.IsVisible = false;
            facility.IsVisible = false;

            if(Data.SelectionManager.GlobalServiceType == "food")
            {
                this.Title = "Food";
                listColor = Color.FromHex("#FF592E");
                food.IsVisible = true;
            }
            else if(Data.SelectionManager.GlobalServiceType == "living")
            {
                this.Title = "Living";
                listColor = Color.FromHex("#FFCA1C");
                living.IsVisible = true;
            }
            else if (Data.SelectionManager.GlobalServiceType == "lifeSkills")
            {
                this.Title = "Life Skills";
                listColor = Color.FromHex("#00FF4C");
                lifeSkills.IsVisible = true;
            }
            else if (Data.SelectionManager.GlobalServiceType == "health")
            {
                this.Title = "Health";
                listColor = Color.FromHex("#63F200");
                health.IsVisible = true;
            }
            else if (Data.SelectionManager.GlobalServiceType == "money")
            {
                this.Title = "Money";
                listColor = Color.FromHex("#A300EF");
                money.IsVisible = true;
            }
            else
            {
                this.Title = "Facilities";
                listColor = Color.FromHex("#3A35EA");
                facility.IsVisible = true;
            }

            header.BackgroundColor = listColor;

        }

        /// <summary>
        /// Sets the current location to the selected item and navigates to the detail menu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SubItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem == null)
            {
                return;
            }
            else
            {
                LocationModel location = (LocationModel)itemList.SelectedItem;
                SelectionManager.GlobalLocationID = location.ID;
                itemList.SelectedItem = null;
                ViewModel.navigationManager.ShowDetailMenu();
            }
        }
    }
}