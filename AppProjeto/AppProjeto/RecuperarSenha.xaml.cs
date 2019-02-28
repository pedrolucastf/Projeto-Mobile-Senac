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
	public partial class RecuperarSenha : ContentPage
	{
		public RecuperarSenha ()
		{
			InitializeComponent ();
		}

        private async void ButtonEnviarCodigo_Clicked(object sender, EventArgs e)
        {
            var confirmarcodigo = new ConfirmarCodigo();
            await Navigation.PushModalAsync(confirmarcodigo);
        }
    }
}