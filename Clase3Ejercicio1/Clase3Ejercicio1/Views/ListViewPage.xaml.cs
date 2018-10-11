using System;
using System.Collections.Generic;
using System.Linq;
using Clase3Ejercicio1.Data;
using Xamarin.Forms;

namespace Clase3Ejercicio1.Views
{
    public partial class ListViewPage : ContentPage
    {
        private List<Article> articles;
        public ListViewPage()
        {
            InitializeComponent();
            articles = new ArticlesGenerator().GenerateList();

            lstShopping.ItemsSource = articles;
            /*
            lstShopping.ItemsSource = new List<string>{
                "Pablo piddy",
                "Dario el yannki",
                "Tengo unn calderon",
                "El lapiz",
                "conciente vevéh",
                "Thu real lominero on tobul no wiri",
                "El mayor"
            };*/
        }

        void Handle_TextChanged(object sender, Xamarin.Forms.TextChangedEventArgs e)
        {
            lstShopping.BeginRefresh();
            if (string.IsNullOrWhiteSpace(e.NewTextValue))
            {
                lstShopping.ItemsSource = articles;
            }
            else
            {
                lstShopping.ItemsSource = articles.Where(x => x.Title.ToLower().Contains(e.NewTextValue.ToLower()));
            }
            lstShopping.EndRefresh();
        }
    }
}
