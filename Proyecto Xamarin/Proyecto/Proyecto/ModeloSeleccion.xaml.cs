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
    public partial class ModeloSeleccion : ContentPage
    {
        public ModeloSeleccion(string marca, string modelo, Uri color1, Uri color2, Uri color3, String correo)
        {
            InitializeComponent();
            marcaSeleccionada = marca;
            modeloSeleccionado = modelo;
            lblModelo.Text = modeloSeleccionado;
            imgcolor1 = color1;
            imgcolor2 = color2;
            imgcolor3 = color3;
            imgGrande.Source = imgcolor1;
            btnColor1.ImageSource = imgcolor1;
            btnColor2.ImageSource = imgcolor2;
            btnColor3.ImageSource = imgcolor3;
            btnColor1.Clicked += BtnColor1_Clicked;
            btnColor2.Clicked += BtnColor2_Clicked;
            btnColor3.Clicked += BtnColor3_Clicked;
            btnContinuePay.Clicked += BtnContinuePay_Clicked;
            verificacionColor(modelo);
            Pruebacolores.Text = colorSeleccionado;
            correoS = correo;

        }
        static string marcaSeleccionada;
        static string modeloSeleccionado;
        static Uri imgcolor1;
        static Uri imgcolor2;
        static Uri imgcolor3;
        static string colorSeleccionado;
        public String correoS;

        private void BtnContinuePay_Clicked(object sender, EventArgs e)
        {
            ((NavigationPage)this.Parent).PushAsync(new BancoPrima(marcaSeleccionada, modeloSeleccionado, colorSeleccionado, correoS));
        }

        private void BtnColor1_Clicked(object sender, EventArgs e)
        {
            imgGrande.Source = imgcolor1;
            verificacionColor(modeloSeleccionado);
            Pruebacolores.Text = colorSeleccionado;
        }

        private void BtnColor2_Clicked(object sender, EventArgs e)
        {
            imgGrande.Source = imgcolor2;
            verificacionColor2(modeloSeleccionado);
            Pruebacolores.Text = colorSeleccionado;
        }
        private void BtnColor3_Clicked(object sender, EventArgs e)
        {
            imgGrande.Source = imgcolor3;
            verificacionColor3(modeloSeleccionado);
            Pruebacolores.Text = colorSeleccionado;
        }

        private void verificacionColor(string modeloSelected)
        {
            switch (modeloSelected)
            {
                case "Stinger":
                    colorSeleccionado = "Negro";
                    break;

                case "GTR":
                    colorSeleccionado = "Negro";
                    break;

                case "UX Hybrid":
                    colorSeleccionado = "Negro";
                    break;

                case "CRV":
                    colorSeleccionado = "Negro";
                    break;

                case "Mustang":
                    colorSeleccionado = "Blanco";
                    break;

                case "LandCruiser":
                    colorSeleccionado = "";
                    break;

                case "Niro EV":
                    colorSeleccionado = "Rojo";
                    break;

                case "370z":
                    colorSeleccionado = "Blanco";
                    break;

                case "LC":
                    colorSeleccionado = "Rojo";
                    break;

                case "HR-V":
                    colorSeleccionado = "Azul";
                    break;

                case "EcoSport":
                    colorSeleccionado = "Negro";
                    break;

                case "Yaris":
                    colorSeleccionado = "Metalico";
                    break;

                case "Rio":
                    colorSeleccionado = "Blanco";
                    break;

                case "Maxima":
                    colorSeleccionado = "Azul";
                    break;

                case "RCF":
                    colorSeleccionado = "Blanco";
                    break;

                case "Accord":
                    colorSeleccionado = "blanco";
                    break;

                case "Explorer":
                    colorSeleccionado = "Roja";
                    break;

                case "AGYA":
                    colorSeleccionado = "Plata";
                    break;
            }
        }


        private void verificacionColor2(string modeloSelected)
        {
            switch (modeloSelected)
            {
                case "Stinger":
                    colorSeleccionado = "Verde";
                    break;

                case "GTR":
                    colorSeleccionado = "Plata";
                    break;

                case "UX Hybrid":
                    colorSeleccionado = "Blanco";
                    break;

                case "CRV":
                    colorSeleccionado = "Metalico";
                    break;

                case "Mustang":
                    colorSeleccionado = "Rojo";
                    break;

                case "LandCruiser":
                    colorSeleccionado = "";
                    break;

                case "Niro EV":
                    colorSeleccionado = "Azul";
                    break;

                case "370z":
                    colorSeleccionado = "Rojo";
                    break;

                case "LC":
                    colorSeleccionado = "Blanco";
                    break;

                case "HR-V":
                    colorSeleccionado = "Negro";
                    break;

                case "EcoSport":
                    colorSeleccionado = "Naranja";
                    break;

                case "Yaris":
                    colorSeleccionado = "Azul";
                    break;

                case "Rio":
                    colorSeleccionado = "Rojo";
                    break;

                case "Maxima":
                    colorSeleccionado = "Negro";
                    break;

                case "RCF":
                    colorSeleccionado = "Azul";
                    break;

                case "Accord":
                    colorSeleccionado = "Plata";
                    break;

                case "Explorer":
                    colorSeleccionado = "plata";
                    break;

                case "AGYA":
                    colorSeleccionado = "Rojo";
                    break;
            }
        }

        private void verificacionColor3(string modeloSelected)
        {
            switch (modeloSelected)
            {
                case "Stinger":
                    colorSeleccionado = "Azul";
                    break;

                case "GTR":
                    colorSeleccionado = "Rojo";
                    break;

                case "UX Hybrid":
                    colorSeleccionado = "Plata";
                    break;

                case "CRV":
                    colorSeleccionado = "Blanco";
                    break;

                case "Mustang":
                    colorSeleccionado = "Azul";
                    break;

                case "LandCruiser":
                    colorSeleccionado = "";
                    break;

                case "Niro EV":
                    colorSeleccionado = "Negro";
                    break;

                case "370z":
                    colorSeleccionado = "Negro";
                    break;

                case "LC":
                    colorSeleccionado = "Negro";
                    break;

                case "HR-V":
                    colorSeleccionado = "Blanco";
                    break;

                case "EcoSport":
                    colorSeleccionado = "Blanco";
                    break;

                case "Yaris":
                    colorSeleccionado = "Negro";
                    break;

                case "Rio":
                    colorSeleccionado = "Azul";
                    break;

                case "Maxima":
                    colorSeleccionado = "Naranja";
                    break;

                case "RCF":
                    colorSeleccionado = "Rojo";
                    break;

                case "Accord":
                    colorSeleccionado = "Negro";
                    break;

                case "Explorer":
                    colorSeleccionado = "Blanco";
                    break;

                case "AGYA":
                    colorSeleccionado = "Naranja";
                    break;
            }
        }
    }
}