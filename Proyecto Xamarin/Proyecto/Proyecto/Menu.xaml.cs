using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Proyecto
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Menu : ContentPage
    {
        public Menu()
        {
            InitializeComponent();
            BtnModelosToyota.Clicked += BtnModelosToyota_Clicked;
            BtnModelosFord.Clicked += BtnModelosFord_Clicked;
            BtnModelosHonda.Clicked += BtnModelosHonda_Clicked;
            BtnModelosLexus.Clicked += BtnModelosLexus_Clicked;
           /*tnModelosNissan.Clicked += BtnModelosNissan_Clicked;*/
            BtnModelosKia.Clicked += BtnModelosKia_Clicked;
        }

        public static string marca;
        public static Uri URLmodelo1;
        public static Uri URLmodelo2;
        public static Uri URLmodelo3;

        private void BtnModelosKia_Clicked(object sender, EventArgs e)
        {
            /*
            marca = "kia";
            URLmodelo1 = "";
            URLmodelo2 = "";
            URLmodelo3 = "";

            */
        }

        private void BtnModelosNissan_Clicked(object sender, EventArgs e)
        {
            /*
            marca = "nissan";
            URLmodelo1 = "";
            URLmodelo2 = "";
            URLmodelo3 = "";

            */
        }

        private void BtnModelosLexus_Clicked(object sender, EventArgs e)
        {
            /*
            marca = "lexus";
            URLmodelo1 = "";
            URLmodelo2 = "";
            URLmodelo3 = "";

            */
        }

        private void BtnModelosHonda_Clicked(object sender, EventArgs e)
        {
            /*
            marca = "honda";
            URLmodelo1 = "";
            URLmodelo2 = "";
            URLmodelo3 = "";

            */
        }

        private void BtnModelosFord_Clicked(object sender, EventArgs e)
        {
            /*
            marca = "ford";
            URLmodelo1 = "";
            URLmodelo2 = "";
            URLmodelo3 = "";

            */
        }

        private void BtnModelosToyota_Clicked(object sender, EventArgs e)
        {
            marca = "toyota";
            URLmodelo1 = new Uri ("https://cdn.discordapp.com/attachments/730938576560193607/833841319260586075/AGYANaranja.png");
            URLmodelo2 = new Uri ("https://cdn.discordapp.com/attachments/730938576560193607/833841315850354738/YarisRedMicaMetallic.png");
            URLmodelo3 = new Uri ("https://cdn.discordapp.com/attachments/730938576560193607/833841327837806602/LandCruiserPradoGrayMetallic.jpg");

            ((NavigationPage)this.Parent).PushAsync(new MenuModelos(URLmodelo1, URLmodelo2, URLmodelo3));
        }
    }
}