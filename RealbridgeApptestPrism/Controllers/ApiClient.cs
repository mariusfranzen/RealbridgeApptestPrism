using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using RealbridgeApptestPrism.Model;

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
            HttpResponseMessage response = await _client.GetAsync("http://api.sr.se/api/v2/channels?format=json");
            if (response.IsSuccessStatusCode)
            {
                string content = await response.Content.ReadAsStringAsync();
                RadioChannel.Channels.RootObject root = JsonConvert.DeserializeObject<RadioChannel.Channels.RootObject>(content);
                return root.channels;
            }
            return null;
        }

        public async Task<RadioMusic.Music.Playlist> GetPlaylists(RadioChannel.Channels.Channel channel)
        {
            HttpResponseMessage response = await _client.GetAsync("http://api.sr.se/api/v2/playlists/rightnow?format=json&channelid=" + channel.id);
            if (response.IsSuccessStatusCode)
            {
                string content = await response.Content.ReadAsStringAsync();
                RadioMusic.Music.RootObject root = JsonConvert.DeserializeObject<RadioMusic.Music.RootObject>(content);
                return root.playlist;
            }
            return null;
        }

    }

}
