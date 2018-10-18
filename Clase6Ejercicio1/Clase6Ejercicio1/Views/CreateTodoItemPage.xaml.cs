using System;
using System.Collections.Generic;
using Clase6Ejercicio1.Models;
using Plugin.Toast;
using Xamarin.Forms;

namespace Clase6Ejercicio1.Views
{
    public partial class CreateTodoItemPage : ContentPage
    {
        public CreateTodoItemPage()
        {
            InitializeComponent();
        }

        async void OnDeleteClicked(object sender, System.EventArgs e)
        {
            var item = BindingContext as TodoItem;
            App.Database.Delete(item);
            await Navigation.PopAsync();
            CrossToastPopUp.Current.ShowToastMessage("To Do Item removed successfully");
        }
        async void OnSaveClicked(object sender, System.EventArgs e)
        {
            var item = BindingContext as TodoItem;

            if (item.ID > 0)
            {
                App.Database.Update(item);
            }
            else
            {
                App.Database.Insert(item);
            }
            await Navigation.PopAsync(); 
            CrossToastPopUp.Current.ShowToastMessage("To Do Item added successfully");
        }

        async void OnCancelClicked(object sender, System.EventArgs e)
        {
            await Navigation.PopAsync();
        }
    }
}
