window.pokemon = window.pokemon || {}

pokemon.backgroundPokemon = function (name) {
    const typeColor = {
        normal: 'rgb(200, 200, 200)',
        fire: 'rgb(255, 120, 0)',
        water: 'rgb(0, 150, 255)',
        electric: 'rgb(255, 255, 0)',
        grass: 'rgb(0, 200, 0)',
        ice: 'rgb(173, 216, 230)',
        fighting: 'rgb(255, 20, 147)',
        poison: 'rgb(148, 0, 211)',
        ground: 'rgb(139, 69, 19)',
        flying: 'rgb(135, 206, 250)',
        psychic: 'rgb(218, 112, 214)',
        bug: ' rgb(0, 128, 0)',
        rock: 'rgb(139, 69, 19)',
        ghost: 'rgb(75, 0, 130)',
        dragon: 'rgb(0, 0, 139)',
        dark: 'rgb(0, 0, 0); color: #ffffff;',
        steel: 'rgb(192, 192, 192)',
        fairy: 'rgb(255, 182, 193)',
    };
    var color = typeColor[name];
    return color;

}
