using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;
using System.Text;
using System.Threading.Tasks;
using Proyecto.Model;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Proyecto
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Transaccion : ContentPage
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

        public Transaccion(string marca, string modelo, string color, float montoCarro, float prima, int plazos, float tasaInteres, double mensualidad, String correo)
        {
            InitializeComponent();
            btnComprar.Clicked += BtnComprar_Clicked;
            marcaSelected = marca;
            modeloS = modelo;
            colorS = color;
            precioCarro = montoCarro;
            primaCarro = prima;
            cantidadPlazos = plazos;
            tasaDeInteres = tasaInteres;
            mensualidadCarro = mensualidad;
            correoS = correo;
        }

        private void BtnComprar_Clicked(object sender, EventArgs e)
        {
            var tipoTar = pickerTipoTarjeta.SelectedIndex.ToString();
            var tituTar = titularTarjeta.Text;
            var numTar = numeroTarjeta.Text;
            var ccvTar = ccvEX.Text;

            Proyecto.Model.Tarjetas resultado = new Proyecto.Model.Tarjetas();

            if (string.IsNullOrEmpty(numTar) || string.IsNullOrEmpty(tituTar) || string.IsNullOrEmpty(ccvTar))
            {
                DisplayAlert("Advertencia", "Por favor, rellene los espacios", "OK");
            }
            else
            {
                try { 
                    resultado = DBConfig.Instancia.GetTarjeta(numTar);

                    if (resultado == null)
                    {
                        throw new NotImplementedException();
                    }
                }
                catch (NotImplementedException f)
                {
                    DisplayAlert("Advertencia", "Usuario no encontrado", "OK");
                    Console.WriteLine("Error en transaccion, GetTarjeta: " + f);
                }

                if (tipoTar != resultado.tipo)
                {
                    DisplayAlert("Advertencia", "Tipo incorrecto", "OK");
                } 
                if (tituTar != resultado.Titular)
                {
                    DisplayAlert("Advertencia", "Titular incorrecto", "OK");
                }
                if (ccvTar != resultado.ccv)
                {
                    DisplayAlert("Advertencia", "CCV incorrecto ", "OK");
                }

                var montoRebajado = resultado.monto - precioCarro;

                int resultadoUpdate = DBConfig.Instancia.UpdateTarjeta(numTar, montoRebajado);

                if (resultadoUpdate == 0)
                {
                    DisplayAlert("Advertencia", "No se logró realizar el update a la BD", "OK");
                } else
                {
                    if (DBConfig.Instancia.AgregarVenta(precioCarro, correoS, marcaSelected, modeloS, colorS) != 0)
                    {
                        ((NavigationPage)this.Parent).PushAsync(new Factura(marcaSelected, modeloS, colorS, precioCarro, primaCarro, cantidadPlazos, tasaDeInteres, mensualidadCarro, correoS));
                    } else
                    {
                        DisplayAlert("Advertencia", "No se logró realizar la venta", "OK");
                    }
                }
            }
                //consultar si existe una tarjeta con el mismo numero de tarjeta y ccv
                //
                //if (si lo hay) {
                //codigo, monto, cedula, marca, modelo, color -> TablaVentas
                //resta primaCarro de monto en la tabla tarjeta
                //}else{ No lo deja pasar a factura }

        }
    }
}