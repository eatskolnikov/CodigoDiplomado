using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Clase2Ejercicio2.Views
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        public void Handle_Clicked(object sender, EventArgs e)
        {
            if(tbxUsername.Text=="root" && tbxPassword.Text=="1234")
            {
                Navigation.PushAsync(new ProfilePage());
            }
            else
            {
                DisplayAlert("Error al entrar!", "Usuario o clave incorrecta", "ok");
            }
        }
    }
}
