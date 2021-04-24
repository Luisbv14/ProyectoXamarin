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
        public Menu(string correo)
        {
            InitializeComponent();
            BtnModelosToyota.Clicked += BtnModelosToyota_Clicked;
            BtnModelosFord.Clicked += BtnModelosFord_Clicked;
            BtnModelosHonda.Clicked += BtnModelosHonda_Clicked;
            BtnModelosLexus.Clicked += BtnModelosLexus_Clicked;
            BtnModelos.Clicked += BtnModelosNissan_Clicked;
            BtnModelosKia.Clicked += BtnModelosKia_Clicked;
            correoS = correo;
        }


        public string correoS; 
        public static string marca;
        public static Uri URLmodelo1;
        public static Uri URLmodelo2;
        public static Uri URLmodelo3;

        private void BtnModelosKia_Clicked(object sender, EventArgs e)
        {
            marca = "Kia";
            URLmodelo1 = new Uri ("https://media.discordapp.net/attachments/730938576560193607/833864740571840542/StringerBlack.png");//18:40 carros negros 1er modelo
            URLmodelo2 = new Uri ("https://media.discordapp.net/attachments/730938576560193607/833864749250510918/NiroEVRed.png"); //18:40 carro rojo 2ndo modelo
            URLmodelo3 = new Uri ("https://media.discordapp.net/attachments/730938576560193607/833864756825554994/RioWhite.png");//18:40 carro blanco 3er modelo

            ((NavigationPage)this.Parent).PushAsync(new MenuModelos(marca,URLmodelo1, URLmodelo2, URLmodelo3, correoS));
        }

        private void BtnModelosNissan_Clicked(object sender, EventArgs e)
        {
           
            marca = "Nissan";
            URLmodelo1 = new Uri ("https://cdn.discordapp.com/attachments/730938576560193607/834151332696424519/GTRBlack.png");
            URLmodelo2 = new Uri ("https://cdn.discordapp.com/attachments/730938576560193607/834151330725625856/370White.png");
            URLmodelo3 = new Uri ("https://cdn.discordapp.com/attachments/730938576560193607/834151323872133220/NissanMaximaBlue.png");

            ((NavigationPage)this.Parent).PushAsync(new MenuModelos(marca, URLmodelo1, URLmodelo2, URLmodelo3, correoS));
            
        }

        private void BtnModelosLexus_Clicked(object sender, EventArgs e)
        {
            marca = "Lexus";
            URLmodelo1 = new Uri ("https://media.discordapp.net/attachments/730938576560193607/833869665897021450/UXHybridBlack.png");//19:00 carro negro 1er modelo (enviado al final)
            URLmodelo2 = new Uri ("https://media.discordapp.net/attachments/730938576560193607/833869658737344562/LCConvertibleRed.png");//19:00 carro rojo 2ndo modelo
            URLmodelo3 = new Uri ("https://media.discordapp.net/attachments/730938576560193607/833869663456722954/RCFWhite.png");//19:00carro blanco 3er modelo

            ((NavigationPage)this.Parent).PushAsync(new MenuModelos(marca, URLmodelo1, URLmodelo2, URLmodelo3, correoS));
        }

        private void BtnModelosHonda_Clicked(object sender, EventArgs e)
        {
            marca = "Honda";
            URLmodelo1 = new Uri ("https://media.discordapp.net/attachments/730938576560193607/833859428029300796/CRVCrystalBlackPearl.png");//18:19 carro negro 1er modelo
            URLmodelo2 = new Uri ("https://media.discordapp.net/attachments/730938576560193607/833859408425254932/HR-VAegeanBlue.png");//18:19 carro azul 2ndo modelo
            URLmodelo3 = new Uri ("https://media.discordapp.net/attachments/730938576560193607/833859425411268628/AccordPlatinumWhite.png");//18:19 carro blanco 3er modelo

            ((NavigationPage)this.Parent).PushAsync(new MenuModelos(marca, URLmodelo1, URLmodelo2, URLmodelo3, correoS));
        }

        private void BtnModelosFord_Clicked(object sender, EventArgs e)
        {
            marca = "Ford";
            URLmodelo1 = new Uri ("https://media.discordapp.net/attachments/730938576560193607/833859793545855016/Oxford_White.png");//18:21 carro blanco 1er modelo
            URLmodelo2 = new Uri ("https://media.discordapp.net/attachments/730938576560193607/833859799090462801/EcoAbsoluteBlackEco.png");//18:21 carro negro 2ndo modelo
            URLmodelo3 = new Uri ("https://media.discordapp.net/attachments/730938576560193607/833859807055708170/ExplorerRapidRed.png");//18:21 carro rojo 3er modelo

            ((NavigationPage)this.Parent).PushAsync(new MenuModelos(marca, URLmodelo1, URLmodelo2, URLmodelo3, correoS));
        }

        private void BtnModelosToyota_Clicked(object sender, EventArgs e)
        {
            marca = "Toyota";
            URLmodelo1 = new Uri ("https://media.discordapp.net/attachments/730938576560193607/833859172847714334/LandCruiserPradoBlack.jpg");//18:18 carro negro 1er modelo
            URLmodelo2 = new Uri ("https://media.discordapp.net/attachments/730938576560193607/833859184381526026/YarisRedMicaMetallic.png");//18:18 carro rojo 2ndo modelo
            URLmodelo3 = new Uri ("https://media.discordapp.net/attachments/730938576560193607/833859187909066782/AGYASilverMetallic.png");//18:18 carro plateado 3er modelo

            ((NavigationPage)this.Parent).PushAsync(new MenuModelos(marca, URLmodelo1, URLmodelo2, URLmodelo3, correoS));
        }
    }
}