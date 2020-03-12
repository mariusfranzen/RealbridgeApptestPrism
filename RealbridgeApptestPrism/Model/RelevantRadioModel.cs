using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Text;

namespace RealbridgeApptestPrism.Model
{
    public class RelevantRadioModel
    {
    }

    public class RadioInfo : BindableBase
    {
        private RadioChannel.Channels.Channel _channel;
        private RadioMusic.Music.Playlist _playlist;

        public RadioChannel.Channels.Channel Channel
        {
            get
            {
                return _channel;
            }
            set
            {
                SetProperty(ref _channel, value);
            }
        }

        public RadioMusic.Music.Playlist Playlist
        {
            get
            {
                return _playlist;
            }
            set
            {
                SetProperty(ref _playlist, value);
            }
        }

    }
}
