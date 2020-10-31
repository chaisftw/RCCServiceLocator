using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using RCC.Data;

[assembly: XamlCompilation (XamlCompilationOptions.Compile)]
namespace RCC
{
	public partial class App : Application
	{
        private ContentPage mainPage;
        private static DBItemManager dbManager;

		public App ()
		{
            InitializeComponent();
            mainPage = new MainPage();

            // Convert the main page into a navigation page
			MainPage = new NavigationPage(mainPage);
            NavigationManager.Instance.Navigation = MainPage.Navigation;
            DataInserter.Insert();
        }

		protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}

        public static DBItemManager DBManager
        {
            get
            {
                // Initialise the database manager
                if(dbManager == null)
                {
                    dbManager = new DBItemManager();
                }
                return dbManager;
            }
        }
	}
}
