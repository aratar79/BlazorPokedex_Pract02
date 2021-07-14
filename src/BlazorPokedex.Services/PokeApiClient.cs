using BlazorPokedex.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace BlazorPokedex.Services
{
    public class PokeApiClient : IPokeApiClient
    {
        private readonly HttpClient _httpClient;
        public PokeApiClient(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<IEnumerable<Pokemon>> GetAllPokemons()
        {
            var result = new List<Pokemon>();

            var request = JsonConvert.DeserializeObject<ResultObject>(await _httpClient.GetStringAsync("pokemon?limit=24&offset=24"));
            
            foreach (var poke in request.Pokemons) 
                result.Add(await GetPokemon(poke.Name));

            return result;
        }

        public async Task<Pokemon> GetPokemon(string name) =>
            JsonConvert.DeserializeObject<Pokemon>(await _httpClient.GetStringAsync($"pokemon/{name}"));

    }
}
