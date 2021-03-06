﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Elemendid2
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Esmaspäev : ContentPage
    {
        Button btn, btn2;
        Label lbl;
        ListView listView;

        public Esmaspäev()
        {
            Title = "ListView";
            string[] tasks = new string[] { "7:00 Tõusen püsti", "7:20 Söön putru", " 8:00 Jalutan", " 10:30 Lähen lõunale", "12:45 Tegelen spordiga", "19:00 Söön", "22:00 Magan" };
            listView = new ListView();
            listView.ItemsSource = tasks;

            btn = new Button()
            {
                Text = "DatePicker",
            };

            btn.Clicked += Btn_Clicked;

            lbl = new Label()
            {
                Text = "ListView",
                HorizontalOptions = LayoutOptions.Center,
                FontSize = 24,
                TextColor = Color.Black,
            };

            btn2 = new Button()
            {
                Text = "Koju",
            };
            btn2.Clicked += Btn_Clicked;

            StackLayout stackLayout = new StackLayout()
            {
                Children = { lbl, listView, btn, btn2 }
            };
            Content = stackLayout;

        }

        private async void Btn_Clicked(object sender, EventArgs e)
        {
            string s = (sender as Button).Text;
            if(s == "DatePicker")
            {
                await Navigation.PushAsync(new Teisipaev());
            }
            else if(s == "Koju")
            {
                await Navigation.PushAsync(new MainPage());
            }
            
        }
    }
}