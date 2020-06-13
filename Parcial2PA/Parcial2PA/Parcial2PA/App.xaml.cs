using Parcial2PA.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Parcial2PA
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new AlbumPage();
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
