using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Xamarin.Forms;
using AISCM;

[assembly: Dependency(typeof(AISCM.Droid.implement_interface))]
namespace AISCM.Droid
{
    public class implement_interface : call_web_service
    {
        public implement_interface() { }
        net.azurewebsites.agc20171.AISCM a = new net.azurewebsites.agc20171.AISCM();
        public string hello_world()
        {
            string msg = "";
            msg = a.HelloWorld();
            return msg;
        }
        public string[] get_farm_status(string email)
        {
            string[] msg = new string[100];
            msg = a.get_current_farm_status(email);
            return msg;
        }
        public string get_water_status(string email)

        {
            string msg = a.get_water_status(Global_portable.email);
            return msg;
        }
        public string[] predict_crops(string email)
        {
            string[] crops = new string[100];
            crops = a.predict_crops(email);
            return crops;
        }
    }
}