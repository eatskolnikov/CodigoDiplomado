using System;
using System.Collections.Generic;
using Clase3Ejercicio1.Data;
using Xamarin.Forms;

namespace Clase3Ejercicio1.Views
{
    public partial class StackPage : ContentPage
    {

        public StackPage()
        {
            InitializeComponent();
            var items = new ArticlesGenerator().GenerateList();

            foreach(var item in items)
            {
                stackDataView.Children.Add(new Image
                {
                    HorizontalOptions = LayoutOptions.Center,
                    WidthRequest=200,
                    Source = item.ImageUrl
                });
                stackDataView.Children.Add(new Label
                {
                    HorizontalOptions = LayoutOptions.Center,
                    Text = item.Title,
                    FontSize=20,
                });
                stackDataView.Children.Add(new Label
                {
                    HorizontalOptions = LayoutOptions.Center,
                    Text = item.Price.ToString("N"),
                    FontSize = 20,
                });
                stackDataView.Children.Add(new Label
                {
                    HorizontalOptions = LayoutOptions.Center,
                    Text = item.Quantity.ToString("D"),
                    FontSize = 20,
                });
            }
        }
    }
}
