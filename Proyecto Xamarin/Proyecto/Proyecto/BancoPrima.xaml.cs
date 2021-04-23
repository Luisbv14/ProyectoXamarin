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
    public partial class BancoPrima : ContentPage
    {
        public BancoPrima(string marca, string modelo, string color)
        {
            InitializeComponent();

            btnCalcular.Clicked += BtnCalcular_Clicked;
            btnCalcularTasa.Clicked += BtnCalcularTasa_Clicked;
            btnAvanzar.Clicked += BtnAvanzar_Clicked;
            marcaSelected =marca;
            modeloSelected =modelo;
            colorSelected = color;
        }

        private void BtnAvanzar_Clicked(object sender, EventArgs e)
        {
            ((NavigationPage)this.Parent).PushAsync(new Transaccion(marcaSelected, modeloSelected, colorSelected, costoVehiculo, primaMonto, cantidadPlazos, tasaInteres, montoMensual));
        }

        static string marcaSelected;
        static string modeloSelected;
        static string colorSelected;

        static float costoVehiculo = 63000;
        static float primaMonto;
        static int cantidadPlazos;
        static float tasaInteres;
        static double montoMensual;


        private void BtnCalcular_Clicked(object sender, EventArgs e)
        {
            
            if (porcentajePrima.SelectedIndex.Equals(0))
            {
                primaMonto = costoVehiculo*(10/100f);
            }
            else if (porcentajePrima.SelectedIndex.Equals(1))
            {
                primaMonto = costoVehiculo * (15 / 100f);
            }
            else if (porcentajePrima.SelectedIndex.Equals(2))
            {
                primaMonto = costoVehiculo * (20 / 100f);
            }

            montoPrima.Text ="El monto de la prima es de: "+ primaMonto;
        }

        private void BtnCalcularTasa_Clicked(object sender, EventArgs e)
        {
            if (plazos.SelectedIndex.Equals(0))
            {
                cantidadPlazos = 60;
                tasaInteres = (7/100f) * 100;
                EnTasa.Text =tasaInteres +"%";

            } else if (plazos.SelectedIndex.Equals(1))
            {
                cantidadPlazos = 84;
                tasaInteres = (7.1f / 100f) * 100;
                EnTasa.Text = tasaInteres + "%";
            }
            else if (plazos.SelectedIndex.Equals(2)) 
            {
                cantidadPlazos = 96;
                tasaInteres = (7.40f / 100f) * 100;
                EnTasa.Text = tasaInteres + "%";
            }
            calcularCuotaMensual();
            EnMontoMensual.Text = "La tasa de interes bajo la cantidad de "+ cantidadPlazos+" es de: "+ montoMensual;

        }


        private void calcularCuotaMensual() 
        {
            montoMensual = ((costoVehiculo * Math.Pow(tasaInteres / 12 * (1 + tasaInteres / 12), cantidadPlazos)) / Math.Pow(1 + tasaInteres / 12, cantidadPlazos)-1);
        }
    }
}