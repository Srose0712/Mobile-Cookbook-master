using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace PocketChef
{
    public partial class App : Application
    {
        public App()
        {
            MainPage = new MainPage();
        }
        async void OnButtonClicked(object sender, EventArgs args)
        {
            Button RecButt = (Button)sender;
            await DisplayAlert("Clicked!",
                              "The button labeled '" + RecButt.Text + "' has been clicked",
                               "OK");
        }

        private Task DisplayAlert(string v1, string v2, string v3)
        {
            throw new NotImplementedException();
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
