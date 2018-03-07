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
    public partial class GetCropView : ContentPage
    {
        public ObservableCollection<GetCropModel> getCrops { get; set; }
        public GetCropView()
        {
            InitializeComponent();
            String[] cropList = new String[100];
            cropList = DependencyService.Get<call_web_service>().get_crops(Global_portable.email);
            getCrops = new ObservableCollection<GetCropModel>();
            for (int i = 0; i < cropList.Length; i++)
            {
                string cropID = "";
                string cropName = "";

                int currloc = 0;
                int nextloc = 0;
                nextloc = cropList[i].IndexOf(":", currloc);
                cropID = cropList[i].Substring(0, nextloc);
                currloc = nextloc + 1;

                cropName = cropList[i].Substring(currloc);

                getCrops.Add(new GetCropModel { CropName = cropName });

            }


            lstView.ItemsSource = getCrops;
        }
    }
}