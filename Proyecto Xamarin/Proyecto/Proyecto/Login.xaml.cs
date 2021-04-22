﻿using System;
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
    public partial class Login : ContentPage
    {
        public Login()
        {
            InitializeComponent();
            btnLogin.Clicked += BtnLogin_Clicked;
            btnRegistrar.Clicked += BtnRegistrar_Clicked;
            btnVerBD.Clicked += BtnVerBD_Clicked;
        }

        private void BtnVerBD_Clicked(object sender, EventArgs e)
        {
            ((NavigationPage)this.Parent).PushAsync(new BD());
        }

        private void BtnRegistrar_Clicked(object sender, EventArgs e)
        {
            ((NavigationPage)this.Parent).PushAsync(new Registro());
        }


        private void BtnLogin_Clicked(object sender, EventArgs e)
        {
            //((NavigationPage)this.Parent).PushAsync(new Menu());

            Proyecto.Model.Usuario resultado = new Proyecto.Model.Usuario();

            if(string.IsNullOrEmpty(usr.Text) || string.IsNullOrEmpty(psw.Text))
            {
                DisplayAlert("Advertencia", "Por favor, rellene los espacios", "OK");
            } else {
                try
                {
                    resultado = DBConfig.Instancia.GetUser(usr.Text);
                } catch(Exception f)
                {
                    DisplayAlert("Advertencia", "Hubo un error", "OK");
                    Console.WriteLine("Error en login: " + f);
                }

                lbl_resultado.Text = "usuario: " + resultado.username + ", contraseña: " + resultado.contraseña;
                if (resultado.contraseña == psw.Text)
                {
                    ((NavigationPage)this.Parent).PushAsync(new Menu());
                } else
                {
                    DisplayAlert("Advertencia", "Las contraseñas es incorrecta", "OK");
                }
            }




            /*if (!(App.listaUsuarios.Find(i => i.username == usr.Text) == null && App.listaUsuarios.Find(i => i.contraseña == psw.Text) == null))
            {
                usr.Text = "";
                psw.Text = "";

                DisplayAlert("Advertencia", "El usuario no existe en la base de datos, por favor, registrese", "Ok");
            }
            else
            {
                ((NavigationPage)this.Parent).PushAsync(new Menu());
            }
            bool userFound = false;
            bool pswFound = false;
            foreach (Usuario user in App.listaUsuarios)
            {
                if (user.username == usr.Text && user.contraseña == psw.Text)
                {
                    userFound = true;
                    pswFound = true;
                    //DisplayAlert("Advertencia", "El usuario ya existe en la base de datos", "Ok");
                    //Console.WriteLine(user.username);
                    //Console.WriteLine(user.contraseña);
                    break;
                }
            }

            usr.Text = "";
            psw.Text = "";

            foreach (Usuario user in App.listaUsuarios)
            {
                Console.WriteLine(user.username);
                Console.WriteLine(user.contraseña);
            }

            if (userFound is true && pswFound is true)
            {
                ((NavigationPage)this.Parent).PushAsync(new Menu());
            } else
            {
                DisplayAlert("Advertencia", "El usuario no existe en la base de datos", "Ok");
                //Console.WriteLine("userfound: " + userFound);
                //Console.WriteLine("pswfound: " + pswFound);
            }
            */

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