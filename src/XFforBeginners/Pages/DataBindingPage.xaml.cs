using System;
using Xamarin.Forms;

namespace XFforBeginners
{
    public partial class DataBindingPage : ContentPage
    {
        public DataBindingPage()
        {
            InitializeComponent();


            // OLD WAY
            welcomeLabel.Text = "this is the old way :[";


            #region NEW WAY

            // ViewModel to data bind to
            var viewModel = new DataBindingPageViewModel
            {
                LabelText = "Hello MNEM! I'm bound to some data!",
                FrameColor = Color.LightGreen,
                IsItFiestaThursday = DateTime.Now,
                IsSwitchOn = true
            };

            // Have to set the BindingContext of the Page
            //this.BindingContext = viewModel;

            #endregion NEW WAY
        }
    }


    // Class to illustrate data binding. This would normally be its own class file
    public class DataBindingPageViewModel
    {
        public string LabelText { get; set; }

        public Color FrameColor { get; set; }

        public bool IsSwitchOn { get; set; }


        // Example of type mismatch
        public DateTime IsItFiestaThursday { get; set; }
    }
}
