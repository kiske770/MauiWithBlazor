using MauiBlazorApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace MauiBlazorApp.Services
{
    internal class CharacterService : ICharacterService
    {
        const string URL= "https://rickandmortyapi.com/api/character";
        public async Task<CharactersModel> Get()
        {
            var httpClient = new HttpClient();
            var response = await httpClient.GetAsync(URL);
            var content =  await response.Content.ReadAsStringAsync();
            var characterList = JsonSerializer.Deserialize<CharactersModel>(content);
            return characterList;
            
        }
    }
}
