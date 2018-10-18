using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

// Probably want to turn this on. Several benefits:
// - It performs compile-time checking of XAML, notifying you of any errors before runtime
// - It removes some of the load and instantiation time for XAML elements
// - It helps to reduce the file size of the final assembly by no longer including.xaml files
[assembly: XamlCompilation(XamlCompilationOptions.Compile)] 

namespace XFforBeginners
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new MainPage();

            //MainPage = new BehaviorsPage();
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
    }
}
