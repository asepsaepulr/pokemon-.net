using Newtonsoft.Json;

namespace Assessment.Pokemon.Models.Pokemon
{
    public class PokemonDetailViewModel
    {
        public int Id { get; set; }
        public string? No { get; set; }
        public string? Name { get; set; }
        public int Order { get; set; }
        public int Weight { get; set; }
        public int Height { get; set; }
        public List<Stats> Stats { get; set; }

        [JsonProperty("sprites")]
        public Sprites Sprites { get; set; }
        public List<Types> Types { get; set; }
        public Species Species { get; set; }
    }

    public class Stats
    {
        [JsonProperty("base_stat")]
        public int BaseStat { get; set; }
        public int Effort { get; set; }
        public Stat Stat { get; set; }
    }

    public class Stat
    {
        public string Name { get; set; }
        public string Url { get; set; }
    }
    public class Types
    {
        public int Slot { get; set; }
        public Type Type { get; set; }
    }
    public class Type
    {
        public string Name { get; set; }
        public string Url { get; set; }
    }
    public class Species
    {
        public string Name { get; set; }
        public string Url { get; set; }
    }
    public class Sprites
    {
        [JsonProperty("back_default")]
        public string BackDefault { get; set; }

        [JsonProperty("back_female")]
        public object BackFemale { get; set; }

        [JsonProperty("back_shiny")]
        public string BackShiny { get; set; }

        [JsonProperty("back_shiny_female")]
        public object BackShinyFemale { get; set; }

        [JsonProperty("front_default")]
        public string FrontDefault { get; set; }

        [JsonProperty("front_female")]
        public object FrontFemale { get; set; }

        [JsonProperty("front_shiny")]
        public string FrontShiny { get; set; }

        [JsonProperty("front_shiny_female")]
        public object FrontShinyFemale { get; set; }

        [JsonProperty("other")]
        public Other Other { get; set; }
    }
    public class Other
    {

        [JsonProperty("official-artwork")]
        public OfficialArtwork OfficialArtwork { get; set; }
    }
    public class OfficialArtwork
    {
        [JsonProperty("front_default")]
        public string FrontDefault { get; set; }

        [JsonProperty("front_shiny")]
        public string FrontShiny { get; set; }
    }
}
