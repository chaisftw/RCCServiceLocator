using Xamarin.Forms;


namespace RCC
{
    public class NavigationManager
    {
        private static NavigationManager instance;
        private INavigation navigation;

        private NavigationManager() { }

        // This property holds the current instance of the navigation manager
        public static NavigationManager Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new NavigationManager();
                }
                return instance;
            }
        }

        public INavigation Navigation
        {
            set { navigation = value; }
        }

        /// <summary>
        /// Navigates to te sub menu
        /// </summary>
        public void ShowSubMenu()
        {
            navigation.PushAsync(new SubMenu());
        }

        /// <summary>
        /// Navigates to the detail menu
        /// </summary>
        public void ShowDetailMenu()
        {
            navigation.PushAsync(new DetailMenu());
        }

        /// <summary>
        /// Navigates to the add menu
        /// </summary>
        public void ShowAddMenu()
        {
            navigation.PushAsync(new AddItem());
        }

        /// <summary>
        /// Navigates to the SOS menu
        /// </summary>
        public void ShowSOS()
        {
            navigation.PushAsync(new SOS());
        }

        /// <summary>
        /// Navigates to the large map
        /// </summary>
        public void ShowMap()
        {
            navigation.PushAsync(new LargeMap());
        }

    }
}
