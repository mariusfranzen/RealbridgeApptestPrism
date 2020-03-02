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

    public class RadioChannel : BindableBase
    {

        private string _id;
        private Image _image;
        private string _tagline;
        private string _siteUrl;
        private string _type;
        private string _music;
        private string _musicArtist;

        public string ID
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

        public Image Image
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

        public string Tagline
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

        public string SiteUrl
        {
            get
            {
                return _siteUrl;
            }
            set
            {
                SetProperty(ref _siteUrl, value);
            }
        }

        public string Type
        {
            get
            {
                return _type;
            }
            set
            {
                SetProperty(ref _type, value);
            }
        }

        public string Music
        {
            get
            {
                return _music;
            }
            set
            {
                SetProperty(ref _music, value);
            }
        }

        public string MusicArtist
        {
            get
            {
                return _musicArtist;
            }
            set
            {
                SetProperty(ref _musicArtist, value);
            }
        }

    }
}
