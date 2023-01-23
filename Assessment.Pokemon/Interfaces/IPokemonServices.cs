using Assessment.Pokemon.Models.Pokemon;
using Refit;

namespace Assessment.Pokemon.Interfaces
{
    public interface IPokemonServices
    {
        [Get("/pokemon?limit=1000&offset=0")]
        Task<PokemonViewModel> GetListPokemon();

        [Get("/pokemon/{name}")]
        Task<object> GetDetailPokemon(string name);
    }
}
