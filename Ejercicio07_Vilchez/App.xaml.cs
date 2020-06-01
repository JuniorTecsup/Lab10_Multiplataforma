using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Ejercicio07_Vilchez.Services;
using Ejercicio07_Vilchez.Views;

namespace Ejercicio07_Vilchez
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            MainPage = new MainPage();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
