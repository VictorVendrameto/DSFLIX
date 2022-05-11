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
    public partial class myers : ContentPage
    {
        public myers()
        {
            InitializeComponent();

            NavigationPage.SetHasNavigationBar(this, false);

            poster.Source = ImageSource.FromResource("AppAdibFlix.Posters.myers.jpg");

            //Web view ou trailer do filme
            var htmlSource = new HtmlWebViewSource();
            htmlSource.Html = @"<iframe width='400' height='300' 
                                        src='https://www.youtube.com/embed/hL6R3HmQfPc'
                                        frameborder ='0'
                                        allow='accelerometer; 
                                        autoplay; 
                                        encrypted-media; 
                                        gyrosccope; 
                                        picture-in-picture'
                                
                                        allowfullscreen
                                </iframe>";

            webview.Source = htmlSource;
        }
    }
}