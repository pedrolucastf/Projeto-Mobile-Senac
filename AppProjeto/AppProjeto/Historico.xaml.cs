using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppProjeto
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Computador : ContentPage
    {
        public Computador()
        {
            InitializeComponent();

            var pc = BuscaTodosComputadores();

            StackLayout sl = new StackLayout();
            sl.Orientation = StackOrientation.Vertical;
            for (var i = 0; i <= 50; i++)
            {

                var label = new Label();
                label.Text = "teste" + i;
                sl.Children.Add(label);

            }

            Content = new ScrollView() { Content = sl };


        }

        private async Task<PC> BuscaTodosComputadores()
        {
            var client = new HttpClient();
            var consulta = client.GetAsync("https://api.mercadolibre.com/sites/MLU/search?q=Computador&access_token=APP_USR-5964333952276604-022513-dbab7c02a409903aa173faebfa26f22e-406674710");
            var resultado = await consulta.Result.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<PC>(resultado);
        }
    }
}