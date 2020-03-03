using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using Xamarin.Forms;

namespace RealbridgeApptestPrism.Model
{
    class MainPageModel
    {
    }
    //Classes that handles the JSON recieved from the API

#pragma warning disable IDE1006 // Naming Styles
    public class RadioChannel
    {

        public class Liveaudio : BindableBase
        {
            private int _id;
            private string _url;
            private string _statkey;

            public int id
            {
                get
                {
                    return _id;
                }
                set
                {
                    SetProperty(ref _id, value);
                }
            }
            public string url
            {
                get
                {
                    return _url;
                }
                set
                {
                    SetProperty(ref _url, value);
                }
            }
            public string statkey
            {
                get
                {
                    return _statkey;
                }
                set
                {
                    SetProperty(ref _statkey, value);
                }
            }
        }

        public class Channel : BindableBase
        {
            private string _image;
            private string _imagetemplate;
            private string _color;
            private string _tagline;
            private string _siteurl;
            private Liveaudio _liveaudio;
            private string _scheduleurl;
            private string _channeltype;
            private string _xmltvid;
            private int _id;
            private string _name;

            public string image
            {
                get
                {
                    return _image;
                }
                set
                {
                    SetProperty(ref _image, value);
                }
            }
            public string imagetemplate
            {
                get
                {
                    return _imagetemplate;
                }
                set
                {
                    SetProperty(ref _imagetemplate, value);
                }
            }
            public string color
            {
                get
                {
                    return _color;
                }
                set
                {
                    SetProperty(ref _color, value);
                }
            }
            public string tagline
            {
                get
                {
                    return _tagline;
                }
                set
                {
                    SetProperty(ref _tagline, value);
                }
            }
            public string siteurl
            {
                get
                {
                    return _siteurl;
                }
                set
                {
                    SetProperty(ref _siteurl, value);
                }
            }
            public Liveaudio liveaudio
            {
                get
                {
                    return _liveaudio;
                }
                set
                {
                    SetProperty(ref _liveaudio, value);
                }
            }
            public string scheduleurl
            {
                get
                {
                    return _scheduleurl;
                }
                set
                {
                    SetProperty(ref _scheduleurl, value);
                }
            }
            public string channeltype
            {
                get
                {
                    return _channeltype;
                }
                set
                {
                    SetProperty(ref _channeltype, value);
                }
            }
            public string xmltvid
            {
                get
                {
                    return _xmltvid;
                }
                set
                {
                    SetProperty(ref _xmltvid, value);
                }
            }
            public int id
            {
                get
                {
                    return _id;
                }
                set
                {
                    SetProperty(ref _id, value);
                }
            }
            public string name
            {
                get
                {
                    return _name;
                }
                set
                {
                    SetProperty(ref _name, value);
                }
            }
        }

        public class Pagination : BindableBase
        {
            private int _page;
            private int _size;
            private int _totalhits;
            private int _totalpages;
            private string _nextpage;

            public int page
            {
                get
                {
                    return _page;
                }
                set
                {
                    SetProperty(ref _page, value);
                }
            }
            public int size
            {
                get
                {
                    return _size;
                }
                set
                {
                    SetProperty(ref _size, value);
                }
            }
            public int totalhits
            {
                get
                {
                    return _totalhits;
                }
                set
                {
                    SetProperty(ref _totalhits, value);
                }
            }
            public int totalpages
            {
                get
                {
                    return _totalpages;
                }
                set
                {
                    SetProperty(ref _totalpages, value);
                }
            }
            public string nextpage
            {
                get
                {
                    return _nextpage;
                }
                set
                {
                    SetProperty(ref _nextpage, value);
                }
            }
        }

        public class RootObject : BindableBase
        {
            private string _copyright;
            private List<Channel> _channels;
            private Pagination _pagination;

            public string copyright
            {
                get
                {
                    return _copyright;
                }
                set
                {
                    SetProperty(ref _copyright, value);
                }
            }
            public List<Channel> channels
            {
                get
                {
                    return _channels;
                }
                set
                {
                    SetProperty(ref _channels, value);
                }
            }
            public Pagination pagination
            {
                get
                {
                    return _pagination;
                }
                set
                {
                    SetProperty(ref _pagination, value);
                }
            }
        }

    }

    public class RadioMusic
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
                get
                {
                    return _title;
                }
                set
                {
                    SetProperty(ref _title, value);
                }
            }
            public string description
            {
                get
                {
                    return _description;
                }
                set
                {
                    SetProperty(ref _description, value);
                }
            }
            public string artist
            {
                get
                {
                    return _artist;
                }
                set
                {
                    SetProperty(ref _artist, value);
                }
            }
            public string composer
            {
                get
                {
                    return _composer;
                }
                set
                {
                    SetProperty(ref _composer, value);
                }
            }
            public string albumname
            {
                get
                {
                    return _albumname;
                }
                set
                {
                    SetProperty(ref _albumname, value);
                }
            }
            public string recordlabel
            {
                get
                {
                    return _recordlabel;
                }
                set
                {
                    SetProperty(ref _recordlabel, value);
                }
            }
            public string lyricist
            {
                get
                {
                    return _lyricist;
                }
                set
                {
                    SetProperty(ref _lyricist, value);
                }
            }
            public DateTime starttimeutc
            {
                get
                {
                    return _starttimeutc;
                }
                set
                {
                    SetProperty(ref _starttimeutc, value);
                }
            }
            public DateTime stoptimeutc
            {
                get
                {
                    return _stoptimeutc;
                }
                set
                {
                    SetProperty(ref _stoptimeutc, value);
                }
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
                get
                {
                    return _title;
                }
                set
                {
                    SetProperty(ref _title, value);
                }
            }
            public string description
            {
                get
                {
                    return _description;
                }
                set
                {
                    SetProperty(ref _description, value);
                }
            }
            public string artist
            {
                get
                {
                    return _artist;
                }
                set
                {
                    SetProperty(ref _artist, value);
                }
            }
            public string composer
            {
                get
                {
                    return _composer;
                }
                set
                {
                    SetProperty(ref _composer, value);
                }
            }
            public string albumname
            {
                get
                {
                    return _albumname;
                }
                set
                {
                    SetProperty(ref _albumname, value);
                }
            }
            public string recordlabel
            {
                get
                {
                    return _recordlabel;
                }
                set
                {
                    SetProperty(ref _recordlabel, value);
                }
            }
            public string lyricist
            {
                get
                {
                    return _lyricist;
                }
                set
                {
                    SetProperty(ref _lyricist, value);
                }
            }
            public DateTime starttimeutc
            {
                get
                {
                    return _starttimeutc;
                }
                set
                {
                    SetProperty(ref _starttimeutc, value);
                }
            }
            public DateTime stoptimeutc
            {
                get
                {
                    return _stoptimeutc;
                }
                set
                {
                    SetProperty(ref _stoptimeutc, value);
                }
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
                get
                {
                    return _title;
                }
                set
                {
                    SetProperty(ref _title, value);
                }
            }
            public string description
            {
                get
                {
                    return _description;
                }
                set
                {
                    SetProperty(ref _description, value);
                }
            }
            public string artist
            {
                get
                {
                    return _artist;
                }
                set
                {
                    SetProperty(ref _artist, value);
                }
            }
            public string composer
            {
                get
                {
                    return _composer;
                }
                set
                {
                    SetProperty(ref _composer, value);
                }
            }
            public string albumname
            {
                get
                {
                    return _albumname;
                }
                set
                {
                    SetProperty(ref _albumname, value);
                }
            }
            public string recordlabel
            {
                get
                {
                    return _recordlabel;
                }
                set
                {
                    SetProperty(ref _recordlabel, value);
                }
            }
            public string lyricist
            {
                get
                {
                    return _lyricist;
                }
                set
                {
                    SetProperty(ref _lyricist, value);
                }
            }
            public DateTime starttimeutc
            {
                get
                {
                    return _starttimeutc;
                }
                set
                {
                    SetProperty(ref _starttimeutc, value);
                }
            }
            public DateTime stoptimeutc
            {
                get
                {
                    return _stoptimeutc;
                }
                set
                {
                    SetProperty(ref _stoptimeutc, value);
                }
            }
        }

        public class Channel : BindableBase
        {
            private int _id;
            private string _name;

            public int id
            {
                get
                {
                    return _id;
                }
                set
                {
                    SetProperty(ref _id, value);
                }
            }
            public string name
            {
                get
                {
                    return _name;
                }
                set
                {
                    SetProperty(ref _name, value);
                }
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
                get
                {
                    return _previoussong;
                }
                set
                {
                    SetProperty(ref _previoussong, value);
                }
            }
            public Song song
            {
                get
                {
                    return _song;
                }
                set
                {
                    SetProperty(ref _song, value);
                }
            }
            public Nextsong nextsong
            {
                get
                {
                    return _nextsong;
                }
                set
                {
                    SetProperty(ref _nextsong, value);
                }
            }
            public Channel channel
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
        }

        public class RootObject : BindableBase
        {
            public Playlist playlist { get; set; }
        }
    }
#pragma warning restore IDE1006 // Naming Styles
}
