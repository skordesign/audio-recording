using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
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
        //ObservableCollection<IShow> _items = new ObservableCollection<IShow>();

        //public ObservableCollection<IShow> Items
        //{
        //    get { return this._items; }
        //}

        //Random fRd, sRd, tRd, frRd = new Random();
        ////Create collections
        //public ObservableCollection<IShow> CreateCollection()
        //{
        //    var cll = new ObservableCollection<IShow>();
        //    cll.Add(new IShow()
        //    {
        //        Ellipse = new SolidColorBrush(Color.FromArgb(Byte.Parse(fRd.Next(0, 255).ToString()),
        //                                                     Byte.Parse(fRd.Next(0, 255).ToString()),
        //                                                     Byte.Parse(fRd.Next(0, 255).ToString()),
        //                                                     Byte.Parse(fRd.Next(0, 255).ToString())))
        //        { },
        //        Text = ""
        //    });
        //    cll.Add(new IShow()
        //    {
        //        Ellipse = new SolidColorBrush(Color.FromArgb(Byte.Parse(fRd.Next(0, 255).ToString()),
        //                                                   Byte.Parse(fRd.Next(0, 255).ToString()),
        //                                                   Byte.Parse(fRd.Next(0, 255).ToString()),
        //                                                   Byte.Parse(fRd.Next(0, 255).ToString())))
        //        { },
        //        Text = ""
        //    });
        //    cll.Add(new IShow()
        //    {
        //        Ellipse = new SolidColorBrush(Color.FromArgb(Byte.Parse(fRd.Next(0, 255).ToString()),
        //                                                   Byte.Parse(fRd.Next(0, 255).ToString()),
        //                                                   Byte.Parse(fRd.Next(0, 255).ToString()),
        //                                                   Byte.Parse(fRd.Next(0, 255).ToString())))
        //        { },
        //        Text = ""
        //    });
        //    return cll;
        //}

        public string YrContent
        {
            get { return (string)GetValue(YrContentProperty); }
            set { SetValue(YrContentProperty, value); }
        }
        public static readonly DependencyProperty YrContentProperty = DependencyProperty.Register("YrContent", typeof(string), typeof(RecNav), null);

        public string MtTb
        {
            get { return (string)GetValue(MtTbProperty); }
            set { SetValue(MtTbProperty, value); }
        }
        public static readonly DependencyProperty MtTbProperty = DependencyProperty.Register("MtTb", typeof(string), typeof(RecNav), null);

        public string DyTb
        {
            get { return (string)GetValue(DTbProperty); }
            set { SetValue(DTbProperty, value); }
        }
        public static readonly DependencyProperty DTbProperty = DependencyProperty.Register("DyTb", typeof(string), typeof(RecNav), null);

        public string NotTb
        {
            get { return (string)GetValue(NotiTbProperty); }
            set { SetValue(NotiTbProperty, value); }
        }
        public static readonly DependencyProperty NotiTbProperty = DependencyProperty.Register("NotTb", typeof(string), typeof(RecNav), null);

        public RecNav()
        {
            this.InitializeComponent();
            YrBtn.Content = DateTime.Today.Year;
        }
        private void ButtonBase_OnClick(object sender, RoutedEventArgs e)
        {

        }
    }
        
    //public class IShow
    //{
    //    public SolidColorBrush Ellipse { get; set; }
    //    public string Text { get; set; }
    //}
}
