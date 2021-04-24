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
    public partial class MenuModelos : ContentPage
    {
        public MenuModelos(string marca, Uri url1, Uri url2, Uri url3, String correo)
        {
            InitializeComponent();
            BtnOpcion1.Clicked += BtnOpcion1_Clicked;
            BtnOpcion2.Clicked += BtnOpcion2_Clicked;
            BtnOpcion3.Clicked += BtnOpcion3_Clicked;
            marcaSelect = marca;
            lblMarca.Text = "Modelos disponibles de la marca " + marcaSelect;
            BtnOpcion1.ImageSource = ImageSource.FromUri(url1);
            BtnOpcion2.ImageSource = ImageSource.FromUri(url2);
            BtnOpcion3.ImageSource = ImageSource.FromUri(url3);
            correoS = correo;
        }
        public static string marcaSelect;
        public static string modeloSeleccionado;
        public static Uri color1;
        public static Uri color2;
        public static Uri color3;
        public String correoS;




        private void BtnOpcion1_Clicked(object sender, EventArgs e)
        {
            if (marcaSelect.Equals("Kia")) 
            {
                modeloSeleccionado = "Stinger";
                color1 = new Uri("https://cdn.discordapp.com/attachments/730938576560193607/833864740571840542/StringerBlack.png");
                color2 = new Uri("https://cdn.discordapp.com/attachments/730938576560193607/833864738051981312/StingerGreen.png");
                color3 = new Uri("https://cdn.discordapp.com/attachments/730938576560193607/833864759711105034/StingerBlue.png");
            }else if(marcaSelect.Equals("Nissan"))
            {
                modeloSeleccionado = "GTR";
                color1 = new Uri("https://cdn.discordapp.com/attachments/730938576560193607/834151332696424519/GTRBlack.png");
                color2 = new Uri("https://cdn.discordapp.com/attachments/730938576560193607/834151321283461180/GTRSilver.png");
                color3 = new Uri("https://cdn.discordapp.com/attachments/730938576560193607/834151320549326868/GTRRed.png");
            }else if(marcaSelect.Equals("Lexus"))
            {
                modeloSeleccionado = "UX Hybrid";
                color1 = new Uri("https://cdn.discordapp.com/attachments/730938576560193607/833869665897021450/UXHybridBlack.png");
                color2 = new Uri("https://cdn.discordapp.com/attachments/730938576560193607/833869655914840105/UXHybridWhite.png");
                color3 = new Uri("https://cdn.discordapp.com/attachments/730938576560193607/833869653754380288/UXHybridSilver.png");
            }else if (marcaSelect.Equals("Honda")) 
            {
                modeloSeleccionado = "CRV";
                color1 = new Uri("https://cdn.discordapp.com/attachments/730938576560193607/833859428029300796/CRVCrystalBlackPearl.png");
                color2 = new Uri("https://cdn.discordapp.com/attachments/730938576560193607/833859400925052928/CRVModernSteelMetallic.png");
                color3 = new Uri("https://cdn.discordapp.com/attachments/730938576560193607/833859404981076018/CRVPlatinumWhitePearl.png");
            }else if (marcaSelect.Equals("Ford")) 
            {
                modeloSeleccionado = "Mustang";
                color1 = new Uri("https://cdn.discordapp.com/attachments/730938576560193607/833859793545855016/Oxford_White.png");
                color2 = new Uri("https://cdn.discordapp.com/attachments/730938576560193607/833859796523810846/Race_Red.png");
                color3 = new Uri("https://cdn.discordapp.com/attachments/730938576560193607/833859786993827860/Kona_Blue.png");
            }else if (marcaSelect.Equals("Toyota")) 
            {
                modeloSeleccionado = "LandCruiser";
                color1 = new Uri("");
                color2 = new Uri("");
                color3 = new Uri("");
            }

            ((NavigationPage)this.Parent).PushAsync(new ModeloSeleccion(marcaSelect,modeloSeleccionado, color1, color2, color3, correoS));
        }

        private void BtnOpcion2_Clicked(object sender, EventArgs e)
        {
            if (marcaSelect.Equals("Kia"))
            {
                modeloSeleccionado = "Niro EV";
                color1 = new Uri("https://cdn.discordapp.com/attachments/730938576560193607/833864749250510918/NiroEVRed.png");
                color2 = new Uri("https://cdn.discordapp.com/attachments/730938576560193607/833864745915908147/NiroEVBlue.png");
                color3 = new Uri("https://cdn.discordapp.com/attachments/730938576560193607/833864743256326174/NiroEVBlack.png");
            }
            else if (marcaSelect.Equals("Nissan"))
            {
                modeloSeleccionado = "370z";
                color1 = new Uri("https://cdn.discordapp.com/attachments/730938576560193607/834151330725625856/370White.png");
                color2 = new Uri("https://cdn.discordapp.com/attachments/730938576560193607/834151329067827211/370Red.png");
                color3 = new Uri("https://cdn.discordapp.com/attachments/730938576560193607/834151327259951164/370Black.png");
            }
            else if (marcaSelect.Equals("Lexus"))
            {
                modeloSeleccionado = "LC";
                color1 = new Uri("https://cdn.discordapp.com/attachments/730938576560193607/833869658737344562/LCConvertibleRed.png");
                color2 = new Uri("https://cdn.discordapp.com/attachments/730938576560193607/833869660423716864/LCConvertibleWhite_.png");
                color3 = new Uri("https://cdn.discordapp.com/attachments/730938576560193607/833869657940426762/LCConvertibleBlack.png");
            }
            else if (marcaSelect.Equals("Honda"))
            {
                modeloSeleccionado = "HR-V";
                color1 = new Uri("https://cdn.discordapp.com/attachments/730938576560193607/833859408425254932/HR-VAegeanBlue.png");
                color2 = new Uri("https://cdn.discordapp.com/attachments/730938576560193607/833859411947552808/HR-VCrystalBlackPearl.png");
                color3 = new Uri("https://cdn.discordapp.com/attachments/730938576560193607/833859414128590878/HR-VPlatinumWhite.png");
            }
            else if (marcaSelect.Equals("Ford"))
            {
                modeloSeleccionado = "EcoSport";
                color1 = new Uri("https://cdn.discordapp.com/attachments/730938576560193607/833859799090462801/EcoAbsoluteBlackEco.png");
                color2 = new Uri("https://cdn.discordapp.com/attachments/730938576560193607/833859801683460116/EcoCanyonRidgeEco.png");
                color3 = new Uri("https://cdn.discordapp.com/attachments/730938576560193607/833859803997667398/EcoDiamondWhite.png");
            }
            else if (marcaSelect.Equals("Toyota"))
            {
                modeloSeleccionado = "Yaris";
                color1 = new Uri("https://cdn.discordapp.com/attachments/730938576560193607/833859184381526026/YarisRedMicaMetallic.png");
                color2 = new Uri("https://cdn.discordapp.com/attachments/730938576560193607/833859183367553054/YarisDarkBlueMicaMetallic.png");
                color3 = new Uri("https://cdn.discordapp.com/attachments/730938576560193607/833859181781843978/ToyotaYarisBlackMicaInk.png");
            }
           ((NavigationPage)this.Parent).PushAsync(new ModeloSeleccion(marcaSelect, modeloSeleccionado, color1, color2, color3, correoS));
        }
        private void BtnOpcion3_Clicked(object sender, EventArgs e)
        {
            if (marcaSelect.Equals("Kia"))
            {
                modeloSeleccionado = "Rio";
                color1 = new Uri("https://cdn.discordapp.com/attachments/730938576560193607/833864756825554994/RioWhite.png");
                color2 = new Uri("https://cdn.discordapp.com/attachments/730938576560193607/833864754392203264/RioRed.png");
                color3 = new Uri("https://cdn.discordapp.com/attachments/730938576560193607/833864751825813534/RioBlue.png");
            }
            else if (marcaSelect.Equals("Nissan"))
            {
                modeloSeleccionado = "Maxima";
                color1 = new Uri("https://cdn.discordapp.com/attachments/730938576560193607/834151323872133220/NissanMaximaBlue.png");
                color2 = new Uri("https://cdn.discordapp.com/attachments/730938576560193607/834151322130579470/NissanMaximaBlack.png");
                color3 = new Uri("https://cdn.discordapp.com/attachments/730938576560193607/834151325574627398/NissanMaximaOrange.png");
            }
            else if (marcaSelect.Equals("Lexus"))
            {
                modeloSeleccionado = "RCF";
                color1 = new Uri("https://cdn.discordapp.com/attachments/730938576560193607/833869663456722954/RCFWhite.png");
                color2 = new Uri("https://cdn.discordapp.com/attachments/730938576560193607/833869661421436978/RCFBlue.png");
                color3 = new Uri("https://cdn.discordapp.com/attachments/730938576560193607/833869662743429180/RCFRed.png");
            }
            else if (marcaSelect.Equals("Honda"))
            {
                modeloSeleccionado = "Accord";
                color1 = new Uri("https://cdn.discordapp.com/attachments/730938576560193607/833859425411268628/AccordPlatinumWhite.png");
                color2 = new Uri("https://cdn.discordapp.com/attachments/730938576560193607/833859420559376444/AccordLunarSilver.png");
                color3 = new Uri("https://cdn.discordapp.com/attachments/730938576560193607/833859417257541692/AccordCrystalBlack.png");
            }
            else if (marcaSelect.Equals("Ford"))
            {
                modeloSeleccionado = "Explorer";
                color1 = new Uri("https://cdn.discordapp.com/attachments/730938576560193607/833859807055708170/ExplorerRapidRed.png");
                color2 = new Uri("https://cdn.discordapp.com/attachments/730938576560193607/833859810117812274/ExplorerSilverSpruce.png");
                color3 = new Uri("https://cdn.discordapp.com/attachments/730938576560193607/833859813913002054/ExplorerStarwhite.png");
            }
            else if (marcaSelect.Equals("Toyota"))
            {
                modeloSeleccionado = "AGYA";
                color1 = new Uri("https://cdn.discordapp.com/attachments/730938576560193607/833859187909066782/AGYASilverMetallic.png");
                color2 = new Uri("https://cdn.discordapp.com/attachments/730938576560193607/833859186622332928/AGYARojo.png");
                color3 = new Uri("https://cdn.discordapp.com/attachments/730938576560193607/833859185866833940/AGYANaranja.png");
            }
            ((NavigationPage)this.Parent).PushAsync(new ModeloSeleccion(marcaSelect, modeloSeleccionado, color1, color2, color3, correoS));
        }
    }
}