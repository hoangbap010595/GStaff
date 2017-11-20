using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace GStaff
{
    public partial class App : Application
    {
        public NavigationPage navigationPage;
        public App()
        {
            InitializeComponent();
            navigationPage = new NavigationPage(new GStaff.LoginPage());
            Application.Current.MainPage = navigationPage;
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

        // Called by the back button in our header/navigation bar.
        public async void OnBackButtonPressed(object sender, EventArgs e)
        {
            await navigationPage.PopAsync();
        }

    }
}
