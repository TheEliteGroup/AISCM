using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace AISCM
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            Global_portable.default_language = "hi-IN";
            MainPage = new NavigationPage(new homepage());
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
