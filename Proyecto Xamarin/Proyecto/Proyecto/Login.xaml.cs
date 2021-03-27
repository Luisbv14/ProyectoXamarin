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
    public partial class Login : ContentPage
    {
        public Login()
        {
            InitializeComponent();
            btnLogin.Clicked += BtnLogin_Clicked;
            btnRegistrar.Clicked += BtnRegistrar_Clicked;
        }

        private void BtnRegistrar_Clicked(object sender, EventArgs e)
        {
            ((NavigationPage)this.Parent).PushAsync(new Registro());
        }


        private void BtnLogin_Clicked(object sender, EventArgs e)
        {
            /*if (!(App.listaUsuarios.Find(i => i.username == usr.Text) == null && App.listaUsuarios.Find(i => i.contraseña == psw.Text) == null))
            {
                DisplayAlert("Advertencia", "El usuario no existe en la base de datos, por favor, registrese", "Ok");
            }
            else
            {
                ((NavigationPage)this.Parent).PushAsync(new Menu());
            }*/
            ((NavigationPage)this.Parent).PushAsync(new Menu());
        }

        /*Copiar y pegar en BtnLogin_Clicked para confirmar si contraseña encriptada = contraseña ingresada, cuando la ruta de BD ya esté definida
        
            var password = txtPassword.Text;

            (Aquí va el código que llama al BD y se trae la contraseña y la llave)

            Byte[] hashB = Convert.FromBase64String(ContraseñaTraidaDeBD);
            Byte[] saltB = Convert.FromBase64String(LlaveTraidaDeBD);

            var success = Argon2.VerifyHash(password, saltB, hashB);

            if (success){
                ((NavigationPage)this.Parent).PushAsync(new Menu());
            }
        */



    }
}