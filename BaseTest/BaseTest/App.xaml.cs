using System;
using System.IO;
using Xamarin.Forms;

namespace BaseTest
{
    public partial class App : Application
    {
        static BaseStadium basestadium;

        public static BaseStadium BaseStadium
        {
            get
            {
                if (basestadium == null)
                {
                    basestadium = new BaseStadium(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Stadiums.db3"));
                }
                return basestadium;
            }
        }

        public App()
        {
            InitializeComponent();

            MainPage = new MainPage();
        }

        protected override void OnStart()   
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}