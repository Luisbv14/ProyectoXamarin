using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Proyecto.Model;

namespace Proyecto
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Registro : ContentPage
    {
        public Registro()
        {
            InitializeComponent();
            btnVerificarRegistro.Clicked += BtnVerificarRegistro_Clicked;
            btnRegresar.Clicked += BtnRegresar_Clicked;
        }

        private void BtnRegresar_Clicked(object sender, EventArgs e)
        {
            ((NavigationPage)this.Parent).PushAsync(new Login());
        }

        private void BtnVerificarRegistro_Clicked(object sender, EventArgs e)
        {
            //verifica si los entrys estan vacios
            if(string.IsNullOrEmpty(txtUsuario.Text) || string.IsNullOrEmpty(txtPassword.Text) || string.IsNullOrEmpty(txtPaswordConfirm.Text) || string.IsNullOrEmpty(txtCorreo.Text))
            {
                DisplayAlert("Advertencia", "Debe llenar todos los campos", "Ok");
            } else
            {
                //verifica si los datos de la contraseña colocados coinciden con los guardados en la lista
                if (txtPassword.Text != txtPaswordConfirm.Text)
                {
                    DisplayAlert("Advertencia", "Las contraseñas deben de coincidir", "Ok");
                }

                StatusMessage.Text = String.Empty; 
                DBConfig.Instancia.AddNewUser(txtUsuario.Text, txtPassword.Text, txtCorreo.Text, 0);
                //StatusMessage.Text = DBConfig.Instancia.EstadoMensajeUsuario; 

                ((NavigationPage)this.Parent).PushAsync(new Login());





                //variables para saber si los datos estan en la base
                //bool userFound = false;
                //bool emailFound = false;

                //revisa cada objeto de la lista para saber si el usuario y la contraseña ya existen en la base de datos
                /*foreach (Usuario user in App.listaUsuarios) {
                     if (user.username == txtUsuario.Text)
                     {
                         userFound = true;
                         DisplayAlert("Advertencia", "El usuario ya existe en la base de datos", "Ok");
                         break;
                     } else if(user.correo == txtCorreo.Text)
                     {
                         emailFound = true;
                         DisplayAlert("Advertencia", "El correo ya existe en la base de datos", "Ok");
                         break;
                     }
                 }*/

                //verifica si los datos no fueron encontrados en la base de datos, en caso de ser así, lo agrega a la base
                /*if (emailFound is false && userFound is false)
                {
                    App.listaUsuarios.Add(new Usuario(txtUsuario.Text, txtPassword.Text, txtCorreo.Text));
                    DisplayAlert("Advertencia", "Usuario " + txtUsuario.Text + " agregado a la base de datos", "Ok");
                    ((NavigationPage)this.Parent).PushAsync(new Login());
                }*/

                //limpia los entrys
                //txtUsuario.Text = "";
                //txtPassword.Text = "";
                // txtPaswordConfirm.Text = "";
                // txtCorreo.Text = "";

                //imprime cada uno de los objetos de la lista
                /*foreach (Usuario user in App.listaUsuarios)
                {
                    Console.WriteLine(user.username);
                    Console.WriteLine(user.contraseña);
                }*/
            }
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