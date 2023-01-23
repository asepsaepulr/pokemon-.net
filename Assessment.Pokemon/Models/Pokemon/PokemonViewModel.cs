namespace Assessment.Pokemon.Models.Pokemon
{
    public class PokemonViewModel
    {
        public int Count { get; set; }
        public string? Next { get; set; }
        public string? Previous { get; set; }
        public List<Result>? Results { get; set; }
    }
    public class Result
    {
        public string? Name { get; set; }
        public string? Url { get; set; }
    }
}
