using System;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace KoguiApp.Services
{
    public class ColorService
    {
        private readonly HttpClient _client;

        public ColorService()
        {
            _client = new HttpClient { BaseAddress = new Uri("https://www.thecolorapi.com/") };
        }

        public async Task<string> ObterNomeCor(string hex)
        {
            try
            {
                var response = await _client.GetFromJsonAsync<ColorApiResponse>($"id?hex={hex.TrimStart('#')}");
                return response?.Name?.Value ?? hex; // fallback para o HEX se algo falhar
            }
            catch
            {
                return hex; // fallback
            }
        }
    }
}
