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
                Console.WriteLine("General Kenobi!");
                return _channel;
            }
            set
            {
                Console.WriteLine("!!!General Kenobi!");
                SetProperty(ref _channel, value);
            }
        }

        public RadioMusic.Music.Playlist Playlist
        {
            get
            {
                Console.WriteLine("You are a bold one.");
                return _playlist;
            }
            set
            {
                Console.WriteLine("!!!You are a bold one.");
                SetProperty(ref _playlist, value);
            }
        }

    }
}
