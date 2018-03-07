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
    public partial class ListBidsView : ContentPage
    {
        public ObservableCollection<ListBidsModel> bidds { get; set; }
        public ListBidsView()
        {
            InitializeComponent();
            String[] bidList = new String[100];
            bidList = DependencyService.Get<call_web_service>().get_bids(Global_portable.email);

            bidds = new ObservableCollection<ListBidsModel>();
            //System.Diagnostics.Debug.WriteLine("CropsP:{0}", bidList[0]);

            if (bidList != null)
            {
                for (int i = 0; i < bidList.Length; i++)
                {

                    string bidID = "";
                    string cropName = "";
                    string cropQuantity = "";
                    string cropRate = "";

                    int currloc = 0;
                    int nextloc = 0;
                    nextloc = bidList[i].IndexOf(",", currloc);
                    //System.Diagnostics.Debug.WriteLine("==========={0} - {1}==========", currloc, nextloc);
                    bidID = bidList[i].Substring(0, nextloc);
                    currloc = nextloc + 1;
                    nextloc = bidList[i].IndexOf(",", currloc);
                    //System.Diagnostics.Debug.WriteLine("==========={0} - {1}==========", currloc, nextloc);
                    // currloc = nextloc + 1;
                    // nextloc = bidList[i].IndexOf(",", currloc);
                    System.Diagnostics.Debug.WriteLine("==========={0} - {1}==========", currloc, bidID);
                    cropName = bidList[i].Substring(currloc, (nextloc - currloc));
                    System.Diagnostics.Debug.WriteLine("==========={0} - {1}==========", bidID, cropName);



                    System.Diagnostics.Debug.WriteLine("Crops:{0} - {1} - {2} - {3}", bidID, cropName, cropQuantity, cropRate);
                    bidds.Add(new ListBidsModel { Name = cropName, BidID = bidID, CropRate = cropRate, CropQuantity = cropQuantity });
                }

                lstView.ItemsSource = bidds;
            }
            else
            {
                bidds.Add(new ListBidsModel { Name = "No Bids Yet", });
            }
        }
    }
}