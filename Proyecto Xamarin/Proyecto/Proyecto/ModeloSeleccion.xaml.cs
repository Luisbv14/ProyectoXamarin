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
        public ModeloSeleccion(string modelo, Uri color1, Uri color2, Uri color3)
        {
            InitializeComponent();
            lblModelo.Text = modelo;
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

        }

        static Uri imgcolor1;
        static Uri imgcolor2;
        static Uri imgcolor3;


        private void BtnColor1_Clicked(object sender, EventArgs e)
        {
            imgGrande.Source = imgcolor1;
        }

        private void BtnColor2_Clicked(object sender, EventArgs e)
        {
            imgGrande.Source = imgcolor2;
        }
        private void BtnColor3_Clicked(object sender, EventArgs e)
        {
            imgGrande.Source = imgcolor3;
        }
    }
}