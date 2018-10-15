﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using Clase5Ejercicio1.Entities;
using Newtonsoft.Json;
using Xamarin.Forms;

namespace Clase5Ejercicio1
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            var client = new WebClient();
            var encodedParameter = HttpUtility.UrlEncode("Santiago");
            var formattedUrl = string.Format(App.Endpoint, encodedParameter);
            var url = new Uri(formattedUrl);
            var resultString = client.DownloadString(url);
            var resultObject = JsonConvert.DeserializeObject<WeatherResponse>(resultString);
            client.Dispose();

            BindingContext = resultObject;
        }
    }
}