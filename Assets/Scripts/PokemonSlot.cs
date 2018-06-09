using UnityEngine;
using UnityEngine.UI;

public class PokemonSlot : MonoBehaviour {

	public Image icon;
	public Text nombre;
	PokemonData pokemon;

	public void AñadirPokemon(PokemonData nuevoPokemon)
	{
		pokemon = nuevoPokemon;
		icon.sprite = pokemon.icon;
		icon.enabled = true;
		nombre.text = pokemon.name.ToString();
		nombre.enabled = true;
	}

}
