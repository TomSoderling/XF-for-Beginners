using Xamarin.Forms;

namespace XFforBeginners.Effects
{
    /// <summary>
    /// Underline effect for Labels that uses CLR properties to pass parameters to the effect
    /// </summary>
    public class LabelUnderlineEffect : RoutingEffect
    {
        public LabelUnderlineEffect() : base("XFforBeginners.LabelUnderlineEffect")
        {
        }

        // A parameter that we can pass into the effect. Use black as the default color.
        public Color LineColor { get; set; } = Color.Black;
    }
}
