using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AISCM
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SelectCropView : ContentPage
    {
        public ObservableCollection<SelectCropModel> veggies { get; set; }
        public SelectCropView()
        {
            InitializeComponent();
            String[] cropList = new String[100];
            cropList = DependencyService.Get<call_web_service>().predict_crops(Global_portable.email);

            veggies = new ObservableCollection<SelectCropModel>();
            System.Diagnostics.Debug.WriteLine("CropsP:{0}", cropList[0]);
            veggies.Add(new SelectCropModel { Parameters = cropList[0] });

            for (int i = 1; i < cropList.Length; i++)
            {
                string cropID = "";
                string cropName = "";

                int currloc = 0;
                int nextloc = 0;
                nextloc = cropList[i].IndexOf(",", currloc);
                cropID = cropList[i].Substring(0, nextloc);
                currloc = nextloc + 1;

                cropName = cropList[i].Substring(currloc);

                System.Diagnostics.Debug.WriteLine("Crops:{0} - {1}", cropID, cropName);
                veggies.Add(new SelectCropModel { Name = cropName, CropID = cropID });
            }
            //  veggies.Add(new SelectCropModel { Name = crops[1], Type = "Fruit" });

            lstView.ItemsSource = veggies;
        }


    }
}