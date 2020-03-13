using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using RealbridgeApptestPrism.Model;
using Xamarin.Forms;

namespace RealbridgeApptestPrism.Controllers
{
    public class ApiClient
    {

        private readonly HttpClient _client;

        public ApiClient()
        {
            _client = new HttpClient();
        }

        public async Task<List<RadioChannel.Channels.Channel>> GetChannels()
        {
            try
            {
                HttpResponseMessage response = await _client.GetAsync("http://api.sr.se/api/v2/channels?format=json");
                response.EnsureSuccessStatusCode();
                string content = await response.Content.ReadAsStringAsync();
                RadioChannel.Channels.RootObject root = JsonConvert.DeserializeObject<RadioChannel.Channels.RootObject>(content);
                return root.channels;
            }
            catch(HttpRequestException e)
            {
                await Application.Current.MainPage.DisplayAlert("Exception!", "Error message: " + e.Message, "OK");
            }
            catch (Exception e)
            {
                await Application.Current.MainPage.DisplayAlert("Exception!", "Error message: " + e.Message, "OK");
            }
            return new List<RadioChannel.Channels.Channel>();
        }

        public async Task<RadioMusic.Music.Playlist> GetPlaylists(RadioChannel.Channels.Channel channel)
        {
            try
            {
                HttpResponseMessage response = await _client.GetAsync("http://api.sr.se/api/v2/playlists/rightnow?format=json&channelid=" + channel.id);
                response.EnsureSuccessStatusCode();
                string content = await response.Content.ReadAsStringAsync();
                RadioMusic.Music.RootObject root = JsonConvert.DeserializeObject<RadioMusic.Music.RootObject>(content);
                return root.playlist;
            }
            catch (HttpRequestException e)
            {
                await Application.Current.MainPage.DisplayAlert("Exception!", "Error message: " + e.Message, "OK");
            }
            catch (Exception e)
            {
                await Application.Current.MainPage.DisplayAlert("Exception!", "Rrror message: " + e.Message, "OK");
            }
            return new RadioMusic.Music.Playlist();
        }

    }

}
