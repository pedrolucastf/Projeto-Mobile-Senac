using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppProjeto
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MenuMaster : MasterDetailPage
    {
        public MenuMaster()
        {
            InitializeComponent();
            Detail = new NavigationPage(new TelaInicio());
        }

        private void ViewCell_Tapped(object sender, EventArgs e)
        {
            Detail.Navigation.PushAsync(new Computador());
            IsPresented = false;
        }
    }
}