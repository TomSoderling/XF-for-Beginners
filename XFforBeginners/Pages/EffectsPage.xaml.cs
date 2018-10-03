using Xamarin.Forms;

namespace XFforBeginners
{
    public partial class EffectsPage : ContentPage
    {
        public EffectsPage()
        {
            InitializeComponent();

            var viewModel = new EffectsPageViewModel
            {
                UnderlinedLabelText = "I wish I were underlined..."
            };

            BindingContext = viewModel;
        }
    }


    // Class to illustrate data binding. This would normally be its own class file
    public class EffectsPageViewModel
    {
        public string UnderlinedLabelText { get; set; }
    }
}
