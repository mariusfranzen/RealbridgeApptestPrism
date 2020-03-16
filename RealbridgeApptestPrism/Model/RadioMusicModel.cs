using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Text;

namespace RealbridgeApptestPrism.Model
{

    public class RadioMusicModel
    {
    }

    public class RadioMusic
    {
#pragma warning disable IDE1006 // Naming Styles
        public class Music
        {
            public class Previoussong : BindableBase
            {
                private string _title;
                private string _description;
                private string _artist;
                private string _composer;
                private string _albumname;
                private string _recordlabel;
                private string _lyricist;
                private DateTime _starttimeutc;
                private DateTime _stoptimeutc;

                public string title
                {
                    get { return _title; }
                    set { SetProperty(ref _title, value); }
                }
                public string description
                {
                    get { return _description; }
                    set { SetProperty(ref _description, value); }
                }
                public string artist
                {
                    get { return _artist; }
                    set { SetProperty(ref _artist, value); }
                }
                public string composer
                {
                    get { return _composer; }
                    set { SetProperty(ref _composer, value); }
                }
                public string albumname
                {
                    get { return _albumname; }
                    set { SetProperty(ref _albumname, value); }
                }
                public string recordlabel
                {
                    get { return _recordlabel; }
                    set { SetProperty(ref _recordlabel, value); }
                }
                public string lyricist
                {
                    get { return _lyricist; }
                    set { SetProperty(ref _lyricist, value); }
                }
                public DateTime starttimeutc
                {
                    get { return _starttimeutc; }
                    set { SetProperty(ref _starttimeutc, value); }
                }
                public DateTime stoptimeutc
                {
                    get { return _stoptimeutc; }
                    set { SetProperty(ref _stoptimeutc, value); }
                }
            }

            public class Song : BindableBase
            {
                private string _title;
                private string _description;
                private string _artist;
                private string _composer;
                private string _albumname;
                private string _recordlabel;
                private string _lyricist;
                private DateTime _starttimeutc;
                private DateTime _stoptimeutc;

                public string title
                {
                    get { return _title; }
                    set { SetProperty(ref _title, value); }
                }
                public string description
                {
                    get { return _description; }
                    set { SetProperty(ref _description, value); }
                }
                public string artist
                {
                    get { return _artist; }
                    set { SetProperty(ref _artist, value); }
                }
                public string composer
                {
                    get { return _composer; }
                    set { SetProperty(ref _composer, value); }
                }
                public string albumname
                {
                    get { return _albumname; }
                    set { SetProperty(ref _albumname, value); }
                }
                public string recordlabel
                {
                    get { return _recordlabel; }
                    set { SetProperty(ref _recordlabel, value); }
                }
                public string lyricist
                {
                    get { return _lyricist; }
                    set { SetProperty(ref _lyricist, value); }
                }
                public DateTime starttimeutc
                {
                    get { return _starttimeutc; }
                    set { SetProperty(ref _starttimeutc, value); }
                }
                public DateTime stoptimeutc
                {
                    get { return _stoptimeutc; }
                    set { SetProperty(ref _stoptimeutc, value); }
                }
            }

            public class Nextsong : BindableBase
            {
                private string _title;
                private string _description;
                private string _artist;
                private string _composer;
                private string _albumname;
                private string _recordlabel;
                private string _lyricist;
                private DateTime _starttimeutc;
                private DateTime _stoptimeutc;

                public string title
                {
                    get { return _title; }
                    set { SetProperty(ref _title, value); }
                }
                public string description
                {
                    get { return _description; }
                    set { SetProperty(ref _description, value); }
                }
                public string artist
                {
                    get { return _artist; }
                    set { SetProperty(ref _artist, value); }
                }
                public string composer
                {
                    get { return _composer; }
                    set { SetProperty(ref _composer, value); }
                }
                public string albumname
                {
                    get { return _albumname; }
                    set { SetProperty(ref _albumname, value); }
                }
                public string recordlabel
                {
                    get { return _recordlabel; }
                    set { SetProperty(ref _recordlabel, value); }
                }
                public string lyricist
                {
                    get { return _lyricist; }
                    set { SetProperty(ref _lyricist, value); }
                }
                public DateTime starttimeutc
                {
                    get { return _starttimeutc; }
                    set { SetProperty(ref _starttimeutc, value); }
                }
                public DateTime stoptimeutc
                {
                    get { return _stoptimeutc; }
                    set { SetProperty(ref _stoptimeutc, value); }
                }
            }

            public class Channel : BindableBase
            {
                private int _id;
                private string _name;

                public int id
                {
                    get { return _id; }
                    set { SetProperty(ref _id, value); }
                }
                public string name
                {
                    get { return _name; }
                    set { SetProperty(ref _name, value); }
                }
            }

            public class Playlist : BindableBase
            {
                private Previoussong _previoussong;
                private Song _song;
                private Nextsong _nextsong;
                private Channel _channel;

                public Previoussong previoussong
                {
                    get { return _previoussong; }
                    set { SetProperty(ref _previoussong, value); }
                }
                public Song song
                {
                    get { return _song; }
                    set { SetProperty(ref _song, value); }
                }
                public Nextsong nextsong
                {
                    get { return _nextsong; }
                    set { SetProperty(ref _nextsong, value); }
                }
                public Channel channel
                {
                    get { return _channel; }
                    set { SetProperty(ref _channel, value); }
                }
            }

            public class RootObject : BindableBase
            {
                private Playlist _playlist;

                public Playlist playlist
                {
                    get { return _playlist; }
                    set { SetProperty(ref _playlist, value); }
                }
            }
        }
#pragma warning restore IDE1006 // Naming Styles
    }
}
