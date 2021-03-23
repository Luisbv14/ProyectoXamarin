using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using System.Diagnostics;
using System.Security.Cryptography;
using Konscious.Security.Cryptography;



namespace Proyecto
{
    class Argon2
    {
        private byte[] CreateSalt()
        {
            var buffer = new byte[16];
            var rng = new RNGCryptoServiceProvider();
            rng.GetBytes(buffer);
            return buffer;
        }

        private byte[] HashPassword(string password, byte[] salt)
        {
            var argon2 = new Argon2id(Encoding.UTF8.GetBytes(password));
            argon2.Salt = salt;
            argon2.DegreeOfParallelism = 4; // / 2 = cantidad de núcleos (2 núcleos)
            argon2.Iterations = 1; //Entre más alto más seguro
            argon2.MemorySize = 700 * 700; // Ej: 1024 * 1024 = 1 GB
            return argon2.GetBytes(16);
        }

        private bool VerifyHash(string password, byte[] salt, byte[] hash)
        {
            var newHash = HashPassword(password, salt);
            return hash.SequenceEqual(newHash);
        }


        /* 
        private void Btn1_Clicked(object sender, EventArgs e)
        {
            var password = Cont1.Text;
            var stopwatch = Stopwatch.StartNew();
            var salt = CreateSalt();
            var hash = HashPassword(password, salt);

            String hashS = Convert.ToBase64String(hash);
            String saltS = Convert.ToBase64String(salt);

            stopwatch.Stop();

            HashPlace.Text = hashS;
            SaltPlace.Text = saltS;
            TimePlace.Text = stopwatch.ElapsedMilliseconds / 1024.0 + "s";
        }*/

        /*private void Btn2_Clicked(object sender, EventArgs e)
        {
            var password = Cont1.Text;

            Byte[] hashB = Convert.FromBase64String(HashPlace.Text);
            Byte[] saltB = Convert.FromBase64String(SaltPlace.Text);

            var success = VerifyHash(password, saltB, hashB);

            if (success)
            {
                Lbl4.Text = "¡La contraseña es la misma!";
            }
            else {
                Lbl4.Text = "La contraseña es diferente";
            }
        */
    }
}
