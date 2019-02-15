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

        private void ButtonConfirmar_Clicked(object sender, EventArgs e)
        {

        }

        private void ButtonCancelar_Clicked(object sender, EventArgs e)
        {

        }
    }
}