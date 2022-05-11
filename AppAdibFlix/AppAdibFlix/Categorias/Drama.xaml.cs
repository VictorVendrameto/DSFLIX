using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppAdibFlix.Categorias
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Drama : ContentPage
    {
        public Drama()
        {
            InitializeComponent();

            btnSoldado.Source = ImageSource.FromResource("AppAdibFlix.Posters.soldado.jpg");
        }

        private void btnSoldado_Clicked(object sender, EventArgs e)
        {
            try
            {
                Navigation.PushAsync(new Categorias.Drama());
            }
            catch (Exception ex)
            {
                DisplayAlert("Vish", ex.Message, "Ok");
            }
        }
    }
}