using System;
using System.Diagnostics;
using System.Linq;
using Foundation;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;
using XFforBeginners.iOS.Effects;

[assembly: ResolutionGroupName("XFforBeginners")] // this is only needed on one effect
[assembly: ExportEffect(typeof(LabelUnderlineEffect), "LabelUnderlineEffect")]

namespace XFforBeginners.iOS.Effects
{
    public class LabelUnderlineEffect : PlatformEffect
    {
        // Called when an effect is attached to a Xamarin.Forms control. 
        // This is the place to perform customization of the control, along with exception handling in case the effect 
        // cannot be applied to the specified Xamarin.Forms control
        protected override void OnAttached()
        {
            try
            {
                // Get an instance of the attached effect, defined in the shared project, so we can get the parameter values to use.
                var effect = (XFforBeginners.Effects.LabelUnderlineEffect)Element.Effects.FirstOrDefault(e => e is XFforBeginners.Effects.LabelUnderlineEffect);

                if (effect != null)
                {
                    var label = (UILabel)Control;
                    var text = (NSMutableAttributedString)label.AttributedText;
                    var range = new NSRange(0, text.Length);

                    var passedInLineColor = effect.LineColor;

                    text.AddAttribute(UIStringAttributeKey.UnderlineStyle, NSNumber.FromInt32((int)NSUnderlineStyle.Single), range);
                    text.AddAttribute(UIStringAttributeKey.UnderlineColor, passedInLineColor.ToUIColor(), range);
                }
                else
                {
                    Debug.WriteLine("Oops, unable to find a LabelUnderlineEffect effect attached to the control.");
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Oops, unable to set property on attached control. {ex.Message}");
            }
        }

        // Called when an effect is detached from a Xamarin.Forms control. 
        // This is the place to perform any effect cleanup such as de-registering an event handler.
        protected override void OnDetached()
        {
            throw new NotImplementedException();
        }
    }
}
