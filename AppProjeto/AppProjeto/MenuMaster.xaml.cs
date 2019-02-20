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

        private void ViewCell_Tapped_1(object sender, EventArgs e)
        {
            Detail.Navigation.PushAsync(new Notebook());
            IsPresented = false;
        }

        private void ViewCell_Tapped_2(object sender, EventArgs e)
        {
            Detail.Navigation.PushAsync(new TV());
            IsPresented = false;
        }
    }
}