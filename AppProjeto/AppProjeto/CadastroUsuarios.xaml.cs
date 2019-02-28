using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using SQLite;
using System.Collections.ObjectModel;

namespace AppProjeto
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class CadastroUsuarios : ContentPage
	{
        private SQLiteAsyncConnection conexao;
        private ObservableCollection<Usuarios> usuarios;

        public CadastroUsuarios ()
		{
			InitializeComponent ();
            conexao = DependencyService.Get<ISQLite>().AcessarDB();
            conexao.CreateTableAsync<Usuarios>();
        }
        protected async override void OnAppearing()
        {
            var listar = await conexao.Table<Usuarios>().ToListAsync(); //select
            usuarios = new ObservableCollection<Usuarios>(listar);
            base.OnAppearing();
        }



        private void ButtonCadastrar_Clicked(object sender, EventArgs e)
        {
            string senha1 = entrySenha1.Text;
            string senha2 = entrySenha2.Text;

            if (senha1 == senha2)
            {
                if (String.IsNullOrEmpty(entryNome.Text) ||
                 String.IsNullOrEmpty(entrySenha1.Text) ||
                 String.IsNullOrEmpty(entrySenha2.Text) ||
                 String.IsNullOrEmpty(entryUsuario.Text))
                {
                    DisplayAlert(null, "Não deixe os campos em branco", "OK");
                }
                else
                {
                    var u = new Usuarios
                    {
                        ID = new Guid(),
                        Nome = entryNome.Text,
                        Usuario = entryUsuario.Text,
                        Senha = entrySenha1.Text
                    };

                    conexao.InsertAsync(entryUsuario);
                    usuarios.Add(u);

                    DisplayAlert(null, "Cadastro efetuado com sucesso", "OK");
                }
            }
            else
            {
                DisplayAlert(null, "As senhas não correspondem", "OK");
            }
        }
    }
}