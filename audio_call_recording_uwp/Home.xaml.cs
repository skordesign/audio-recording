using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Media.Capture;
using Windows.Media.MediaProperties;
using Windows.Storage;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace audio_call_recording_uwp
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Home : Page
    {
        public Home()
        {
            this.InitializeComponent();
        }
        private MediaCapture mediaCapture;
        private LowLagMediaRecording lowLagMedia;
        private StorageFile storageFile;
        private StorageFolder storageFolder;

        protected override async void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);
            Storyboard.Begin();
            //CameraCaptureUI camera = new CameraCaptureUI();
            //camera.VideoSettings.Format = CameraCaptureUIVideoFormat.Mp4;

            //StorageFile videoFile = await camera.CaptureFileAsync(CameraCaptureUIMode.PhotoOrVideo);
            //if (videoFile == null)
            //{
            //    return;
            //}
        }

        private void MediaCapture_Failed(MediaCapture sender, MediaCaptureFailedEventArgs errorEventArgs)
        {
        }

        private async void ButtonBase_OnClick(object sender, RoutedEventArgs e)
        {
            mediaCapture = new MediaCapture();
            await mediaCapture.InitializeAsync();

            storageFolder = ApplicationData.Current.LocalFolder;
            storageFile = await storageFolder.CreateFileAsync("test.mp3", CreationCollisionOption.GenerateUniqueName);
            lowLagMedia = await mediaCapture.PrepareLowLagRecordToStorageFileAsync(
                MediaEncodingProfile.CreateMp3(AudioEncodingQuality.High), storageFile);
            await lowLagMedia.StartAsync();
        }

        private async void StopBtn_OnClick(object sender, RoutedEventArgs e)
        {

            await lowLagMedia.FinishAsync();
          
        }

        private async void PlayBtn_OnClick(object sender, RoutedEventArgs e)
        {
            storageFile = await storageFolder.GetFileAsync("test.mp3");
            mediaElement.Source = new Uri(storageFile.Path);
            mediaElement.Play();
        }
    }
}
