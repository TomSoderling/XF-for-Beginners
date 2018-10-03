using System;
using Xamarin.Forms;

namespace XFforBeginners
{
    public partial class DataBindingPage : ContentPage
    {
        public DataBindingPage()
        {
            InitializeComponent();


            //welcomeLabel.Text = "this is the old way :[";


            // View Model to data bind to
            var viewModel = new DataBindingPageViewModel
            {
                LabelText = "Hello MDC! I'm bound to some data!",
                FrameColor = Color.LightGreen,
                IsItFiestaWednesday = DateTime.Now
            };

            this.BindingContext = viewModel;
        }
    }


    // Class to illustrate data binding. This would normally be its own class file
    public class DataBindingPageViewModel
    {
        public string LabelText { get; set; }

        public Color FrameColor { get; set; }

        // Example of type mismatch
        public DateTime IsItFiestaWednesday { get; set; }
    }
}
