using System;
using System.IO;
using Clase6Ejercicio1.Data;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace Clase6Ejercicio1
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new MainPage());
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }

        static MyLocalDatabase database;

        public static MyLocalDatabase Database
        {
            get{
                if (database == null)
                {
                    var dbpath = 
                        Path.Combine(
                            Environment.GetFolderPath(
                                Environment.SpecialFolder.LocalApplicationData), "myLocalDatabase.db3");

                    database = new MyLocalDatabase(dbpath);
                }
                return database;

            }
        }
    }
}
