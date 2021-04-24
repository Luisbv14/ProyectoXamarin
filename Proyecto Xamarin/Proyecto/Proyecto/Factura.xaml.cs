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
    public partial class Factura : ContentPage
    {
        static string marcaSelected;
        static string modeloS;
        static string colorS;
        static float precioCarro;
        static float primaCarro;
        static int cantidadPlazos;
        static float tasaDeInteres;
        static double mensualidadCarro;
        public String correoS;

        public Factura(string marca, string modelo, string color, float montoCarro, float prima, int plazos, float tasaInteres, double mensualidad, String correo)
        {
            InitializeComponent();
            //btnVolver.Clicked += btnVolver_Clicked;
            marcaSelected = marca;
            modeloS = modelo;
            colorS = color;
            precioCarro = montoCarro;
            primaCarro = prima;
            cantidadPlazos = plazos;
            tasaDeInteres = tasaInteres;
            mensualidadCarro = mensualidad;
            correoS = correo;

            txtmarca.Text = marcaSelected;
            txtmodelo.Text = modeloS;
            txtcolor.Text = colorS;
            txtprecio.Text = precioCarro.ToString();
            txtprima.Text = primaCarro.ToString();
            txtplazos.Text = cantidadPlazos.ToString();
            txtinteres.Text = tasaDeInteres.ToString();
            txtmensual.Text = mensualidadCarro.ToString();
        }

        private void BtnComprar_Clicked(object sender, EventArgs e)
        {
            ((NavigationPage)this.Parent).PushAsync(new Menu(correoS));
        }
    }
}