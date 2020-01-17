using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using voipapp.Views;

namespace voipapp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new Appelwind();
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
