using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using RealbridgeApptestPrism.Model;
using RealbridgeApptestPrism.Controllers;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace RealbridgeApptestPrism.ViewModels
{
    public class MainPageViewModel : ViewModelBase
    {
        private bool _isRefreshing;
        private ObservableCollection<RadioInfo> _radio;
        private readonly ApiClient _apiClient = new ApiClient();

        public bool IsRefreshing
        {
            get
            {
                return _isRefreshing;
            }
            set
            {
                SetProperty(ref _isRefreshing, value);
            }
        }
        public ObservableCollection<RadioInfo> Radio
        {
            get
            {
                return _radio;
            }
            set
            {
                //Prevents "a property or indexer may not be passed as an out or ref parameter" error
                SetProperty(ref _radio, value);
            }
        }
        public ICommand RefreshCommand { get; set; }
        public ICommand ItemTappedCommand { get; set; }

        public MainPageViewModel(INavigationService navigationService)
            : base(navigationService)
        {
            Title = "Test";
            IsRefreshing = false;
            _radio = new ObservableCollection<RadioInfo>();

            RefreshCommand = new Command(RefreshList, CanRefreshList);
            ItemTappedCommand = new Command(TapItem, CanTapItem);
            RefreshList();
        }

        private async void RefreshList()
        {
            IsRefreshing = true;
            List<RadioChannel.Channels.Channel> radioChannels = new List<RadioChannel.Channels.Channel>(await _apiClient.GetChannels());
            List<RadioMusic.Music.Playlist> radioPlaylists = new List<RadioMusic.Music.Playlist>();
            ObservableCollection<RadioInfo> radio = new ObservableCollection<RadioInfo>();
            foreach (var item in radioChannels)
            {
                radioPlaylists.Add(await _apiClient.GetPlaylists(item));
            }
            foreach (var channelItem in radioChannels)
            {
                RadioInfo radioInfo = new RadioInfo();
                radioInfo.Channel = channelItem;
                foreach (var musicItem in radioPlaylists)
                {
                    if (channelItem.id == musicItem.channel.id)
                    {
                        radioInfo.Playlist = musicItem;
                        goto Found;
                    }
                }
            Found:
                radio.Add(radioInfo);
            }
            Radio = radio;
            IsRefreshing = false;
        }

        private bool CanRefreshList()
        {
            //TODO: Can refresh?
            return true;
        }

        private void TapItem()
        {

        }

        private bool CanTapItem()
        {
            return true;
        }

    }
}
