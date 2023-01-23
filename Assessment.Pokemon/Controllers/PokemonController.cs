using Assessment.Pokemon.Interfaces;
using Assessment.Pokemon.Models.Pokemon;
using Hanssens.Net;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace Assessment.Pokemon.Controllers
{
    public class PokemonController : Controller
    {
        private readonly IPokemonServices _clientApi;

        public PokemonController(IPokemonServices clientApi)
        {
            _clientApi = clientApi;
        }
        public async Task<IActionResult> PokemonList()
        {
            var result = await _clientApi.GetListPokemon();
            return View(result);
        }
        public async Task<IActionResult> PokemonDetail(string name)
        {

            var result = await _clientApi.GetDetailPokemon(name);
            PokemonDetailViewModel model = JsonConvert.DeserializeObject<PokemonDetailViewModel>(result.ToString());
            model.No = model?.Order.ToString("D3");

            return View(model);
        }
        public IActionResult MyPokemon()
        {
            return View();
        }

        }
    }
