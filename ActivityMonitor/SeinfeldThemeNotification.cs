using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Windows.Storage;
using Windows.Media.Playback;
using Windows.Devices.Gpio;
using Windows.System.Threading;

namespace ActivityMonitor
{
    class SeinfeldThemeNotification
    {
        public async Task NotifyAsync()
        {
            StorageFile file = await StorageFile.GetFileFromApplicationUriAsync(new Uri("ms-appx:///Assets/Seinfeld_transition_01.mp3"));
            MediaPlayer player = BackgroundMediaPlayer.Current;
            player.AutoPlay = false;
            player.SetFileSource(file);
            player.Volume = 100;
            player.Play();
        }
    }
}
