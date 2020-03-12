using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Text;

namespace RealbridgeApptestPrism.Model
{

    public class RadioChannelModel
    {
    }

    public class RadioChannel
    {
#pragma warning disable IDE1006 // Naming Styles
        public class Channels
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

#pragma warning restore IDE1006 // Naming Styles

    }
}
