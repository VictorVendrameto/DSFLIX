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
    public partial class Aventura : ContentPage
    {
        public Aventura()
        {
            InitializeComponent();

            NavigationPage.SetHasNavigationBar(this, false);

            btnBianca.Source = ImageSource.FromResource("AppAdibFlix.Posters.bianca.png");
        }

        private void btnBianca_Clicked(object sender, EventArgs e)
        {
            try
            {
                Navigation.PushAsync(new bianca());
            }
            catch (Exception ex)
            {
                DisplayAlert("Vish", ex.Message, "Ok");
            }
        }
    }
}