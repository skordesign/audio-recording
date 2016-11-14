using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.ApplicationModel;
using Windows.Media.Capture;
using Windows.Media.MediaProperties;
using Windows.Storage;
using Windows.Storage.Streams;
using Windows.UI.Core;
using Windows.UI.Xaml.Controls;

namespace audio_call_recording_uwp.Models
{
    class AudioRecording
    {
        private MediaCapture _mediaCapture; //capabilities for capture video, picture and audio
        private InMemoryRandomAccessStream _memoryBuffer; //capture input from Microphone into memory
        private bool IsRecording { get; set; }
    }
}
