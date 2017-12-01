using System;
using Xamarin.Forms;

namespace PocketChef
{
    public class InfoPage : ContentPage 
    {
        public InfoPage()
        {
            Label label = new Label();
            {
                DisplayAlert("Gesture Info", "I got Clicked!", "OK");;
            } 


        }
    }
}
