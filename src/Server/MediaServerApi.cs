using Lunitor.MediaServerMonitor.Server.Models;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace Lunitor.MediaServerMonitor.Server
{
    public class MediaServerApi : IMediaServerApi
    {
        private readonly HttpClient _client;

        public MediaServerApi(HttpClient client, IConfiguration configuration)
        {
            _client = client;
            _client.BaseAddress = new Uri(configuration.GetValue<string>("Jellyfin:Url"));
            _client.DefaultRequestHeaders.Add("X-Emby-Token", configuration.GetValue<string>("Jellyfin:Token"));
        }

        public async Task<IEnumerable<Session>> GetAllSessionsAsync()
        {
            var response = await _client.GetStringAsync("/sessions");

            return JsonSerializer.Deserialize<IEnumerable<Session>>(response);
        }
    }
}
