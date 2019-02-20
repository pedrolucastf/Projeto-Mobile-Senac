using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AppProjeto
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void ButtonEntrar_Clicked(object sender, EventArgs e)
        {
            if (entryLogin.Text == "admin" && entrySenha.Text == "admin")
            {
                //Abre página master do aplicativo. 
                var page = new MenuMaster();
                await Navigation.PushModalAsync(page);
            }
            else
            {
                await DisplayAlert("Ops...", "Login e/ou senha incorretos!", "OK");
            }
        }

        private async void ButtonNovoUsuario_Clicked(object sender, EventArgs e)
        {
            var cadastro = new CadastroUsuarios();
            await Navigation.PushModalAsync(cadastro);
        }

        private async void ButtonEsqueciSenha_Clicked(object sender, EventArgs e)
        {
            var recuperarsenha = new RecuperarSenha();
            await Navigation.PushModalAsync(recuperarsenha);
        }
    }
}
