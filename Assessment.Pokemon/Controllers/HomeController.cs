using Assessment.Pokemon.Models;
using Assessment.Pokemon.Models.Pokemon;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Diagnostics;

namespace Assessment.Pokemon.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        HttpClient client = new HttpClient();
        string url = "https://pokeapi.co/api/v2/pokemon?limit=10&offset=10";

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public async Task<IActionResult> Index()
        {
            return View(JsonConvert.DeserializeObject<PokemonViewModel>(await client.GetStringAsync(url)));
        }

        public async Task<IActionResult> Detail(string name)
        {
            var url = "https://pokeapi.co/api/v2/pokemon/" + name;

            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri(url);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

                HttpResponseMessage response = await client.GetAsync(url);
                if (response.IsSuccessStatusCode)
                {
                    var data = await response.Content.ReadAsStringAsync();
                    // deserialize first since json is your response type
                    var table = Newtonsoft.Json.JsonConvert.DeserializeObject(data);
                    // re serialize with formatting:
                    //model.ReturnedJson = JsonConvert.SerializeObject(table, Formatting.Indented);
                }
            }
            return View(JsonConvert.DeserializeObject<PokemonViewModel>(await client.GetStringAsync(url)));
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}