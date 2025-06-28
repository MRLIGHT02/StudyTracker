using System;
using System.Collections.Generic;
using System.Linq;
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
#if ANDROID
            if (Handler is IEntryHandler entryHandler)
            {
                entryHandler.PlatformView.BackgroundTintList = Android.Content.Res.ColorStateList.ValueOf(Colors.Transparent.ToPlatform());
            }
#endif
        }
    }
}
