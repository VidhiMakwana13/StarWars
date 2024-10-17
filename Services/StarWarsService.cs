using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using StarWarsCharacters.Models;

namespace StarWarsCharacters.Services
{
    public class StarWarsService
    {
        private readonly HttpClient _httpClient;

        public StarWarsService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<CharacterResponse> GetCharactersAsync(int page)
        {
            var response = await _httpClient.GetFromJsonAsync<CharacterResponse>($"https://swapi.dev/api/people/?page={page}");
            return response;
        }
    }
}
