using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using System.Diagnostics;

namespace Proyecto
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            /*Task.Delay(new TimeSpan(0, 0, 2)).ContinueWith(o => { ((NavigationPage)this.Parent).PushAsync(new Login()); });*/
            
            
             BtnBienvenida.Clicked += BtnBienvenida_Clicked;
        }

        private void BtnBienvenida_Clicked(object sender, EventArgs e)
        {
            ((NavigationPage)this.Parent).PushAsync(new Login());

        }
    }
}

