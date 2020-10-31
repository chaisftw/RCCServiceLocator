using System.Windows.Input;
using Xamarin.Forms;
using System;
using System.ComponentModel;

namespace RCC
{
    public class ViewModel : ViewModelBase
    {
        public static NavigationManager navigationManager;

        public ICommand MainClickedCommand { protected set; get; }
        public ICommand SubClickedCommand { protected set; get; }
        public ICommand AddClickedCommand { protected set; get; }
        public ICommand SOSCall000Command { protected set; get; }
        public ICommand CallCommand { protected set; get; }
        public ICommand SOSClickedCommand { protected set; get; }
        public ICommand MapClickedCommand { protected set; get; }

        // Data bindings for the add item screen (For testing database functionality)
        public string NameEntry { get; set; }
        public string SuburbEntry { get; set; }
        public string IconEntry { get; set; }

        public ViewModel()
        {
            navigationManager = NavigationManager.Instance;

            MainClickedCommand = new Command<string>( MainPress );
            CallCommand = new Command<string>(Call);

            // Adds a new item to the database, then navigates to the sub menu
            AddClickedCommand = new Command(() =>
            {
                App.DBManager.SaveDBLocation(new Models.LocationModel { ID = 0, Name = NameEntry, Suburb = SuburbEntry, Lat = 0.0, Long = 0.0, Icon = IconEntry, Image = "picture.png" });
                navigationManager.ShowSubMenu();
            });

            //Navigation commands...
            SubClickedCommand = new Command(() =>
            {

                navigationManager.ShowDetailMenu();
            });

            SOSClickedCommand = new Command(() =>
            {
                navigationManager.ShowSOS();
            });

            MapClickedCommand = new Command(() =>
            {
                navigationManager.ShowMap();
            });
        }

        /// <summary>
        /// Sets the service type to the service type selected when pressing a main menu button, then navigates to the sub menu
        /// </summary>
        /// <param name="value"></param>
        void MainPress(string value)
        {
            Data.SelectionManager.GlobalServiceType = value;

            Console.WriteLine(Data.SelectionManager.GlobalServiceType);
            navigationManager.ShowSubMenu();
        }

        // Opens the devices dialer with the phone number already entered
        void Call(string value)
        {
            Device.OpenUri(new Uri("tel:" + value));
        }

    }
}
