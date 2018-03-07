using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AISCM
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Sidebar : ContentPage
    {
        public Sidebar()
        {
            InitializeComponent();
            BindingContext = new SidebarViewModel();
        }
    }
}