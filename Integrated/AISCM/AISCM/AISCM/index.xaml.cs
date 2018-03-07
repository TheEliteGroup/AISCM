﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AISCM
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class index : ContentPage
    {
        public index()
        {
            InitializeComponent();
            Global_portable.email = "aditya.sd12@gmail.com";

            var names = new List<string>
            {
                "Crop1.jpg", "Crop2.jpg", "Crop3.jpg"
            };

            
        }

        private async void OnMonitorStatusClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new monitorstatus());
        }
        private async void OnSelectCropClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new SelectCropView());
        }
        private async void OnViewCropClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new GetCropView());
        }
        private async void OnCropMarketClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new CropMarketView());
        }
    }
}