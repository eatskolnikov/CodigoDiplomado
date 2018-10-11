using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Clase3Ejercicio1.Views
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        void Handle_Clicked(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new StackPage());
        }

        void Handle_Clicked_1(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new GridPageExample());
        }

        void Handle_Clicked_2(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new GridPage());
        }

        void Handle_Clicked_3(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new ListViewPage());
        }
    }
}
