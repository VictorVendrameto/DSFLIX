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
    public partial class JohnWick3 : ContentPage
    {
        public JohnWick3()
        {
            InitializeComponent();

            NavigationPage.SetHasNavigationBar(this, false);

            poster.Source = ImageSource.FromResource("AppAdibFlix.Posters.JohnWick.png");

            //Web view ou trailer do filme
            var htmlSource = new HtmlWebViewSource();
            htmlSource.Html = @" <iframe width='400' height='300' 
                                        src='https://www.youtube.com/embed/M7XM597XO94'
                                        frameborder ='0' 
                                        allow ='accelerometer; 
                                        autoplay; 
                                        clipboard-write; 
                                        encrypted-media; 
                                        gyroscope; 
                                        picture-in-picture'
                                        allowfullscreen>
                                </iframe>";
        }
    }
}