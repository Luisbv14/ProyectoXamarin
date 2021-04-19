using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Proyecto.Model;

namespace Proyecto
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class BD : ContentPage
    {
        public BD()
        {
            InitializeComponent();
            btnMostrarBD.Clicked += BtnMostrarBD_Clicked;
        }

        private void BtnMostrarBD_Clicked(object sender, EventArgs e)
        {
            var allUsers = DBConfig.Instancia.GetAllUsers();
            userList.ItemsSource = allUsers;
            StatusMessage.Text = DBConfig.Instancia.EstadoMensajeUsuario;
        }
    }
}