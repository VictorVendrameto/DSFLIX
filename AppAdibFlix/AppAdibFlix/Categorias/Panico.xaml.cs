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
    public partial class Panico : ContentPage
    {
        public Panico()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);

            poster.Source = ImageSource.FromResource("AppAdibFlix.Posters.panico.jpg");

            //Web view ou trailer do filme
            var htmlSource = new HtmlWebViewSource();
            htmlSource.Html = @"<iframe width='400' height='300' 
                                        src='https://www.youtube.com/embed/swzTZ2mQypM'
                                        frameborder ='0'
                                        allow='accelerometer; autoplay; encrypted-media; gyrosccope; picture-in-picture'
                                
                                        allowfullscreen
                                </iframe>";

            webview.Source = htmlSource;
        }
    }
}