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
        public Transaccion()
        {
            InitializeComponent();
            btnComprar.Clicked += BtnComprar_Clicked;
        }

        private void BtnComprar_Clicked(object sender, EventArgs e)
        {
            var tipoTar = pickerTipoTarjeta.SelectedIndex;
            var tituTar = TitularTarjeta.Text;
            var numTar = numeroTarjeta.Text;
            var ccvTar = ccvEX.Text;

        }
    }
}