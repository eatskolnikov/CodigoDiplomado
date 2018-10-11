using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Clase1Ejercicio1
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        void Handle_Clicked(object sender, System.EventArgs e)
        {
            var age = (DateTime.UtcNow.Year - dtpBirthDay.Date.Year);
            lblAge.Text = $"Tienes {age} anios de edad";

        }
    }
}
