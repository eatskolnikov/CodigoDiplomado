using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Clase4Ejercicio1
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        public void Handle_Clicked(object sender, EventArgs e)
        {
            webBrowser.Source = tbxAddress.Text;
        }
    }
}
