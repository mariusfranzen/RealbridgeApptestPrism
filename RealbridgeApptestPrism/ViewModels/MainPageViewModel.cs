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
        private readonly ApiClient _apiClient;
        private RadioInfo _selectedItem;

        public bool IsRefreshing
        {
            get { return _isRefreshing; }
            set { SetProperty(ref _isRefreshing, value); }
        }
        public ObservableCollection<RadioInfo> Radio
        {
            get { return _radio; }
            set { SetProperty(ref _radio, value); }
        }
        public RadioInfo SelectedItem
        {
            get { return _selectedItem; }
            set { SetProperty(ref _selectedItem, value); }
        }
        public ICommand RefreshCommand { get; set; }
        public ICommand ItemTappedCommand { get; set; }

        public MainPageViewModel(INavigationService navigationService)
            : base(navigationService)
        {
            Title = "Test";
            IsRefreshing = false;
            _radio = new ObservableCollection<RadioInfo>();
            _apiClient = new ApiClient();

            RefreshCommand = new Command(RefreshList, CanRefreshList);
            ItemTappedCommand = new Command(TapItem, CanTapItem);

            RefreshList();
        }

        private async void RefreshList()
        {
            IsRefreshing = true;
            var radioChannels = new List<RadioChannel.Channels.Channel>(await _apiClient.GetChannels());
            var radioPlaylists = new List<RadioMusic.Music.Playlist>();
            var radio = new ObservableCollection<RadioInfo>();
            foreach (var channelItem in radioChannels)
            {
                radioPlaylists.Add(await _apiClient.GetPlaylists(channelItem));
            }
            foreach (var channelItem in radioChannels)
            {
                var radioInfo = new RadioInfo();
                radioInfo.Channel = channelItem;

                var found = false;
                foreach (var musicItem in radioPlaylists)
                {
                    if (found)
                        break;

                    if (channelItem.id == musicItem.channel.id)
                    {
                        radioInfo.Playlist = musicItem;
                        found = true;
                    }
                }
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
            //TODO: Tap item
        }

        private bool CanTapItem()
        {
            //TODO: Can tap item?
            return true;
        }

    }
}
