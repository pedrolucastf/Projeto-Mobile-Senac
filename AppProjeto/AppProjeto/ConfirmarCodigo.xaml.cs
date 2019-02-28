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
	public partial class ConfirmarCodigo : ContentPage
	{
		public ConfirmarCodigo ()
		{
			InitializeComponent ();
		}

        private async void ButtonConfirmar_Clicked(object sender, EventArgs e)
        {
            var novasenha = new NovaSenha();
            await Navigation.PushModalAsync(novasenha);
        }

        private async void ButtonCancelar_Clicked(object sender, EventArgs e)
        {
            var retornarlogin = new MainPage();
            await Navigation.PushModalAsync(retornarlogin);
        }
    }
}