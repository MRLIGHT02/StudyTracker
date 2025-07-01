using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Maui.Controls.Platform;
using Microsoft.Maui.Handlers;
using Microsoft.Maui.Platform;

namespace StudyTracker.CustomControls
{
    class CustomEnteryBorder : Entry
    {

        protected override void OnHandlerChanged()
        {
            base.OnHandlerChanged();
            SetBorderBackGround();
            FontSize = 20;
        }
        protected override void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            base.OnPropertyChanged(propertyName);
            if (propertyName == nameof(BackgroundColor))
            {

                SetBorderBackGround();
            }
        }
        private void SetBorderBackGround()
        {

#if ANDROID
            if (Handler is IEntryHandler entryHandler)

            {
                var shape = new Android.Graphics.Drawables.GradientDrawable();
                shape.SetShape(Android.Graphics.Drawables.ShapeType.Rectangle);
                if (BackgroundColor == null)
                {
                    entryHandler.PlatformView.BackgroundTintList = Android.Content.Res.ColorStateList.ValueOf(Colors.Transparent.ToPlatform());

                }
                else
                {

                    entryHandler.PlatformView.BackgroundTintList = Android.Content.Res.ColorStateList.ValueOf(BackgroundColor.ToPlatform());
                    shape.SetStroke(2, Android.Graphics.Color.Black);
                    shape.SetCornerRadius(10f);
                    entryHandler.PlatformView.SetBackground(shape);
                }

                int leftpadding = 0;
                int rightpadding = 0;
                int toppadding = 0;
                int bottompadding = 20;
                entryHandler.PlatformView.SetPadding(leftpadding, toppadding, rightpadding, bottompadding);

            }

#endif
        }
    }
}
