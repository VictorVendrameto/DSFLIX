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
    public partial class Acao : ContentPage
    {
        public Acao()
        {
            InitializeComponent();
            btnJohn.Source = ImageSource.FromResource("AppAdibFlix.Posters.JohnWick.png");
        }

        private void btnJohn_Clicked(object sender, EventArgs e)
        {
            try
            {
                Navigation.PushAsync(new JohnWick3());
            }
            catch (Exception ex)
            {
                DisplayAlert("Vish", ex.Message, "Ok");
            }
        }
    }
}