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
    public partial class Transaccion : ContentPage
    {
        public Transaccion(string marca, string modelo, string color, float montoCarro, float prima, int plazos, float tasaInteres, double mensualidad)
        {
            InitializeComponent();
            btnComprar.Clicked += BtnComprar_Clicked;
            marcaSelected = marca;
            modeloS = modelo;
            colorS = color;
            precioCarro = montoCarro;
            primaCarro = prima;


        }

        static string marcaSelected;
        static string modeloS;
        static string colorS;
        static float precioCarro;
        static float primaCarro;
        static int cantidadPlazos;
        static float tasaDeInteres;
        static double mensualidadCarro;


        private void BtnComprar_Clicked(object sender, EventArgs e)
        {
            var tipoTar = pickerTipoTarjeta.SelectedIndex;
            var tituTar = TitularTarjeta.Text;
            var numTar = numeroTarjeta.Text;
            var ccvTar = ccvEX.Text;
            ((NavigationPage)this.Parent).PushAsync(new Menu());

        }
    }
}