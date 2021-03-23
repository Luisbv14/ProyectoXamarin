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
    public partial class Registro : ContentPage
    {
        public Registro()
        {
            InitializeComponent();
        }

        /* Copiar y pegar en btnVerificarRegistro_Clicked después que se verifique correctamente la información ingresada, y luego
        ingresar una contraseña incriptada y su llave a BD

            var password = txtPassword;
            var salt = Argon2.CreateSalt();
            var hash = Argon2.HashPassword(password, salt);

            String hashS = Convert.ToBase64String(hash);
            String saltS = Convert.ToBase64String(salt);

            (Aquí va código para copiar hashS t saltS y pegarlos en los espacios de contraseña y llave en la BD)
        }*/
    }
}