using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
using Windows.UI;
using Windows.UI.Popups;
using Windows.UI.ViewManagement;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace audio_call_recording_uwp
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            MyFrame.Navigate(typeof(Home));

        }
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);
            if (ApiInformation.IsTypePresent("Windows.UI.ViewManagement.ApplicationView"))
            {
                var title = ApplicationView.GetForCurrentView().TitleBar;
                if (title != null)
                {
                    title.BackgroundColor = Colors.Aqua;
                    title.ButtonBackgroundColor = Colors.BlueViolet;
                    title.ButtonHoverBackgroundColor = Colors.Black;
                }
            }
        }

        private void ButtonBase_OnClick(object sender, RoutedEventArgs e)
        {

            SplitView.IsPaneOpen = !SplitView.IsPaneOpen;
            if (SplitView.IsPaneOpen == true)
            {
                FindRdoBtn.Visibility = Visibility.Collapsed;
                MyAutoSuggestBox.Visibility = Visibility.Visible;
                li1.Width = li2.Width = li3.Width = 220;
                li1.HorizontalAlignment = li2.HorizontalAlignment = li3.HorizontalAlignment = HorizontalAlignment.Center;
                li1.Margin = li2.Margin = li3.Margin = new Thickness(0, 10, 0, 0);
            }
            else
            {
                FindRdoBtn.Visibility = Visibility.Visible;
                MyAutoSuggestBox.Visibility = Visibility.Collapsed;
                li1.Width = li2.Width = li3.Width = 38;
                li1.HorizontalAlignment = li2.HorizontalAlignment = li3.HorizontalAlignment = HorizontalAlignment.Left;
                li1.Margin = li2.Margin = li3.Margin = new Thickness(5, 10, 0, 0);
            }
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {

        }

        private async void MainPage_OnLoaded(object sender, RoutedEventArgs e)
        {


        }
    }
}
