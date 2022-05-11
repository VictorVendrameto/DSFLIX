using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AppAdibFlix
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

 

        }
        


        //botão
        private void Btn_Open_Aventura(object sender, EventArgs e)
        {
            try
            {
                Navigation.PushAsync(new Categorias.Aventura());
            }
            catch (Exception ex)
            {
                DisplayAlert("Vish", ex.Message, "Ok");
            }
        }

        private void Btn_Open_Acao(object sender, EventArgs e)
        {
            try
            {
                Navigation.PushAsync(new Categorias.Acao());
            }
            catch (Exception ex)
            {
                DisplayAlert("Vish", ex.Message, "Ok");
            }
        }

        private void Btn_Open_Terror(object sender, EventArgs e)
        {
            try
            {
                Navigation.PushAsync(new Categorias.Terror());
            }
            catch (Exception ex)
            {
                DisplayAlert("Vish", ex.Message, "Ok");
            }
        }

        private void Btn_Open_Drama(object sender, EventArgs e)
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
