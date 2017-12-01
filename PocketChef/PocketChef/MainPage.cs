﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace PocketChef
{
    public class MainPage : ContentPage
    {
        

        Deck stack;
        DeckModel model = new DeckModel();

        public MainPage()
        {
            this.BindingContext = model;
            this.BackgroundColor = Color.FromHex("272727");

            RelativeLayout view = new RelativeLayout();

            stack = new Deck();
            stack.SetBinding(Deck.ItemsSourceProperty, "ItemsList");
            stack.SwipedLeft += SwipedLeft;
            stack.SwipedRight += SwipedRight;

            view.Children.Add(stack, Constraint.Constant(30), Constraint.Constant(60),
                Constraint.RelativeToParent((parent) => { return parent.Width - 60; }),
                Constraint.RelativeToParent((parent) => { return parent.Height - 140; }));

            this.LayoutChanged += (object sender, EventArgs e) =>
            {
                stack.CardMoveDistance = (int)(this.Width * 0.20f);
            };
            this.Content = view;
            Button RecButt = new Button
            {
                /*Text = "See This Recipe!",
                TextColor = Color.White,
                BackgroundColor = Color.FromHex("900C3F"),
                BorderRadius = 10,
                FontSize = 20,
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Center,
                InputTransparent = true,*/
            };
            view.Children.Add(RecButt,
             Constraint.Constant(0),
                 Constraint.RelativeToParent((parent) =>
                 {
                     return parent.Height - 55;
                 }),
                 Constraint.RelativeToParent((parent) =>
                 {
                     return parent.Width;
                 }),
                 Constraint.Constant(40));
            
            RecButt.Clicked += async (sender, e) => 
            {
                await Navigation.PushModalAsync(new InfoPage()); 
            };


        }

        void SwipedLeft(int index)
        {
            DisplayAlert("Gesture Info", "Swipe Left Detected", "OK");
        }
        void SwipedRight(int index)
        {
            DisplayAlert("Gesture Info", "Swipe Right Detected", "OK");
        }
        //void OnButtonClicked(object sender, EventArgs e)
        //{
          //  DisplayAlert("Gesture Info", "Button Click Detected", "OK");
           // clickTotal += 1;
            //label.Text = String.Format("{0} button click{1}",
                                     //  clickTotal, clickTotal == 1 ? "" : "s");
        //}
    }
}





        