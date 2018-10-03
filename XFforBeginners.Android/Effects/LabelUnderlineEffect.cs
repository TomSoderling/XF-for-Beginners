using System;
using System.Diagnostics;
using System.Linq;
using Android.Graphics;
using Android.Widget;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using XFforBeginners.Droid.Effects;

[assembly: ResolutionGroupName("XFforBeginners")] // this is only needed on one effect
[assembly: ExportEffect(typeof(LabelUnderlineEffect), "LabelUnderlineEffect")]

namespace XFforBeginners.Droid.Effects
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
                    var textView = (TextView)Control;
                    textView.PaintFlags |= PaintFlags.UnderlineText;

                    // TODO: couldn't figure out how to color the line on Android
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
