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
    public partial class Terror : ContentPage
    {
        public Terror()
        {
            InitializeComponent();

            btnMyers.Source = ImageSource.FromResource("AppAdibFlix.Posters.myers.jpg");
            btnBlackPhone.Source = ImageSource.FromResource("AppAdibFlix.Posters.BlackPhone.jpg");
            btnPanico.Source = ImageSource.FromResource("AppAdibFlix.Posters.panico.jpg");
            btnInvocacao.Source = ImageSource.FromResource("AppAdibFlix.Posters.invocacao.jpg");
        }

        private void btnMyers_Clicked(object sender, EventArgs e)
        {
            try
            {
                Navigation.PushAsync(new myers());
            }
            catch (Exception ex)
            {
                DisplayAlert("Vish", ex.Message, "Ok");
            }
        }

        private void btnBlackPhone_Clicked(object sender, EventArgs e)
        {
            try
            {
                Navigation.PushAsync(new BlackPhone());
            }
            catch (Exception ex)
            {
                DisplayAlert("Vish", ex.Message, "Ok");
            }
        }

        private void btnPanico_Clicked(object sender, EventArgs e)
        {
            try
            {
                Navigation.PushAsync(new Panico());
            }
            catch (Exception ex)
            {
                DisplayAlert("Vish", ex.Message, "Ok");
            }
        }

        private void btnInvocacao_Clicked(object sender, EventArgs e)
        {
            try
            {
                Navigation.PushAsync(new invocacao());
            }
            catch (Exception ex)
            {
                DisplayAlert("Vish", ex.Message, "Ok");
            }
        }
    }
}