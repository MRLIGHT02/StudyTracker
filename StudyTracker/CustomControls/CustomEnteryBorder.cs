using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
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
                if (BackgroundColor == null)
                {
                    entryHandler.PlatformView.BackgroundTintList = Android.Content.Res.ColorStateList.ValueOf(Colors.Transparent.ToPlatform());
                }
                else
                {

                    entryHandler.PlatformView.BackgroundTintList = Android.Content.Res.ColorStateList.ValueOf(BackgroundColor.ToPlatform());
                }
            }

#endif
        }
    }
}
