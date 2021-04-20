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
        public MenuModelos( Uri url1, Uri url2, Uri url3)
        {
            InitializeComponent();
            BtnOpcion1.Clicked += BtnOpcion1_Clicked;
            BtnOpcion2.Clicked += BtnOpcion2_Clicked;
            BtnOpcion3.Clicked += BtnOpcion3_Clicked;
            BtnOpcion1.ImageSource = ImageSource.FromUri(url1);
            BtnOpcion2.ImageSource = ImageSource.FromUri(url2);
            BtnOpcion3.ImageSource = ImageSource.FromUri(url3);
        }

        private void BtnOpcion3_Clicked(object sender, EventArgs e)
        {
            ((NavigationPage)this.Parent).PushAsync(new ModeloSeleccion());
        }

        private void BtnOpcion2_Clicked(object sender, EventArgs e)
        {
            ((NavigationPage)this.Parent).PushAsync(new ModeloSeleccion());
        }

        private void BtnOpcion1_Clicked(object sender, EventArgs e)

        {
            ((NavigationPage)this.Parent).PushAsync(new ModeloSeleccion());
        }
    }
}