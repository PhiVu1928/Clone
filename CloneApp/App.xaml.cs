using System;
using CloneApp.Views;
using CloneApp.Services;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CloneApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            DependencyService.Register<CartServices>();
            MainPage = new AppShell();
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
