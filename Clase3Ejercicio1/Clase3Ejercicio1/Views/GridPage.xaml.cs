using System;
using System.Collections.Generic;
using Clase3Ejercicio1.Data;
using Xamarin.Forms;

namespace Clase3Ejercicio1.Views
{
    public partial class GridPage : ContentPage
    {
        public GridPage()
        {
            InitializeComponent(); 
            var items = new ArticlesGenerator().GenerateList();
            gridDataView.ColumnDefinitions.Add(new ColumnDefinition
            {
                Width = GridLength.Star
            });
            gridDataView.ColumnDefinitions.Add(new ColumnDefinition
            {
                Width = GridLength.Star
            });
            for (var i = 0; i < items.Count; ++i)
            {
                var item = items[i];

                gridDataView.RowDefinitions.Add(new RowDefinition { Height = 100 });

                gridDataView.Children.Add(new Image
                {
                    HorizontalOptions = LayoutOptions.Center,
                    Aspect = Aspect.Fill,
                    Source = item.ImageUrl
                }, 0, i);


                var stackLayout = new StackLayout();

                stackLayout.Children.Add(new Label
                {
                    HorizontalOptions = LayoutOptions.Center,
                    Text = item.Title,
                    FontSize = 24,
                });
                stackLayout.Children.Add(new Label
                {
                    HorizontalOptions = LayoutOptions.Center,
                    Text ="US$"+ item.Price.ToString("N"),
                    FontSize = 24,
                });
                stackLayout.Children.Add(new Label
                {
                    HorizontalOptions = LayoutOptions.Center,
                    Text = item.Quantity.ToString("D"),
                    FontSize = 24,
                });

                gridDataView.Children.Add(stackLayout, 1, i);
            }
        }
    }
}
