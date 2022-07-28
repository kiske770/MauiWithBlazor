using MauiBlazorApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiBlazorApp.Services
{
    internal interface ICharacterService
    {
        public Task<CharactersModel> Get();
    }
}
