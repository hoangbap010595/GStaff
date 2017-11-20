using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using GStaff.Models;
using GStaff.Views;

namespace GStaff
{
    public partial class GStaffPage : MasterDetailPage
    {
        public List<MainMenuItem> MainMenuItems { get; set; }

        public GStaffPage()
        {
            NavigationPage.SetHasNavigationBar(this, false);
            // Set the binding context to this code behind.
            BindingContext = this;

            // Build the Menu
            MainMenuItems = new List<MainMenuItem>()
            {
                new MainMenuItem() {NoID = 1, Title = "Dashboard", Icon = (Device.RuntimePlatform == Device.iOS ? "ic_dashboard_48pt.png" : "ic_dashboard_black_48dp.png"), TargetType = typeof(DashboardPage) }
                ,new MainMenuItem() {NoID = 38, Title = "Setting", Icon = (Device.RuntimePlatform == Device.iOS ? "ic_settings_48pt.png" : "ic_settings_black_48dp.png"), TargetType = typeof(AboutPage) }
                ,new MainMenuItem() {NoID = 39, Title = "About", Icon = (Device.RuntimePlatform == Device.iOS ? "ic_info_outline_48pt.png" : "ic_info_outline_black_48dp.png"), TargetType = typeof(AboutPage) }
                ,new MainMenuItem() {NoID = 40, Title = "Logout", Icon = (Device.RuntimePlatform == Device.iOS ? "ic_lock_outline_48pt.png" : "ic_lock_outline_black_48dp.png"), TargetType = typeof(AboutPage) }
            };
            // Set the default page, this is the "home" page.
            Detail = new NavigationPage(new DashboardPage());
            InitializeComponent();
        }

        private void MenuListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var item = e.SelectedItem as MainMenuItem;
            if(item!= null)
            {
                switch (item.NoID)
                {
                    case 1:
                        Detail = new NavigationPage(new DashboardPage());
                        break;
                    case 2:
                        Detail = new NavigationPage(new AboutPage());
                        break;
                    case 3:
                        break;
                    case 38:
                        Detail = new NavigationPage(new SettingPage());
                        break;
                    case 39:
                        DisplayAlert("MESSAGE", "ABOUT", "OK");
                        break;
                    case 40:
                        DisplayAlert("MESSAGE", "LOGOUT", "OK");
                        break;
                    default:
                        break;
                }
                MenuListView.SelectedItem = null;
                IsPresented = false;
            }
        }

    }
}
