using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.ApplicationModel.Store;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Windows.UI.Xaml.Shapes;

// The User Control item template is documented at http://go.microsoft.com/fwlink/?LinkId=234236

namespace audio_call_recording_uwp.User_Controls
{
    public sealed partial class RecNav : UserControl
    {

        public string MonthTextblock
        {
            get { return (string)GetValue(MonthTextblockProperty); }
            set { SetValue(MonthTextblockProperty, value); }
        }

        // Using a DependencyProperty as the backing store for MonthTextblock.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty MonthTextblockProperty =
            DependencyProperty.Register("MonthTextblock", typeof(string), typeof(RecNav), null);


        public string DayTextblock
        {
            get { return (string)GetValue(DayTectblockProperty); }
            set { SetValue(DayTectblockProperty, value); }
        }

        // Using a DependencyProperty as the backing store for DayTectblock.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty DayTectblockProperty =
            DependencyProperty.Register("DayTectblock", typeof(string), typeof(RecNav), null);




        public string Notification
        {
            get { return (string)GetValue(NotificationProperty); }
            set { SetValue(NotificationProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Notification.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty NotificationProperty =
            DependencyProperty.Register("Notification", typeof(string), typeof(RecNav), null);



    }
}
