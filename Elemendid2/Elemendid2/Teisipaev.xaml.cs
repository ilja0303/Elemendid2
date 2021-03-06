﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Elemendid2
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Teisipaev : ContentPage
    {
        Button btn1, btn2;
        Label lbl;
        DatePicker datePicker;
        public Teisipaev()
        {

            datePicker = new DatePicker
            {
                MinimumDate = new DateTime(2020, 1, 1),
                MaximumDate = new DateTime(2020, 12, 31),
                Date = new DateTime(2020, 10, 23),
            };

            Title = "DatePicker";

            btn1 = new Button()
            {
                Text = "TableView",
            };
            btn1.Clicked += Btn1_Clicked;

            btn2 = new Button()
            {
                Text = "Koju",
            };
            btn2.Clicked += Btn1_Clicked;

            lbl = new Label()
            {
                Text = "DatePicker",
            };

            StackLayout stackLayout = new StackLayout()
            {
                Children = { lbl, datePicker, btn1, btn2}
            };
            Content = stackLayout;
        }



        private async void Btn1_Clicked(object sender, EventArgs e)
        {
            string s = (sender as Button).Text;
            if(s == "TableView")
            {
                await Navigation.PushAsync(new Kolmapaev());
            }
            else if (s == "Koju")
            {
                await Navigation.PushAsync(new MainPage());
            }

        }
    }
}