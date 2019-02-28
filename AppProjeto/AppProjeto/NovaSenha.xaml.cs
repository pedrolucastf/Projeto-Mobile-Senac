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
	public partial class NovaSenha : ContentPage
	{
		public NovaSenha ()
		{
			InitializeComponent ();
		}

        private async void ButtonSalvarSenha_Clicked(object sender, EventArgs e)
        {
            var senha = new MainPage();
            await Navigation.PushModalAsync(senha);
        }
    }
}