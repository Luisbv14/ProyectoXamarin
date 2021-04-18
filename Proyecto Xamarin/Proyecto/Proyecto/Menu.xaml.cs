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
        public Menu()
        {
            InitializeComponent();
            BtnModelosToyota.Clicked += BtnModelosToyota_Clicked;
            BtnModelosFord.Clicked += BtnModelosFord_Clicked;
            BtnModelosHonda.Clicked += BtnModelosHonda_Clicked;
            BtnModelosLexus.Clicked += BtnModelosLexus_Clicked;
            BtnModelosNissan.Clicked += BtnModelosNissan_Clicked;
            BtnModelosKia.Clicked += BtnModelosKia_Clicked;
        }

        private void BtnModelosKia_Clicked(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void BtnModelosNissan_Clicked(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void BtnModelosLexus_Clicked(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void BtnModelosHonda_Clicked(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void BtnModelosFord_Clicked(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void BtnModelosToyota_Clicked(object sender, EventArgs e)
        {
            ((NavigationPage)this.Parent).PushAsync(new MenuModelos());
        }
    }
}