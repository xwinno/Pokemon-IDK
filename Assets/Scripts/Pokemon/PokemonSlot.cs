using UnityEngine;
using UnityEngine.UI;

public class PokemonSlot : MonoBehaviour {

	public Image icon;
	public Text nombre;
	public Text vida;
	public Text experiencia;
	public float siguienteNivel;
	PokemonData pokemon;

	public void AñadirPokemon(PokemonData nuevoPokemon)
	{
		pokemon = nuevoPokemon;
		icon.sprite = pokemon.icon;
		icon.enabled = true;
		nombre.text = pokemon.name.ToString();
		nombre.enabled = true;
		vida.text = "HP - " + pokemon.salud + "/" + pokemon.salud;
		vida.enabled = true;
		
		var LevelUp = pokemon.nivel + 1;
		siguienteNivel = (6 * (Mathf.Pow(LevelUp,3)) / 5  - 15 * (Mathf.Pow(LevelUp, 2)) + 100 * (LevelUp) - 140);
		var atexto = siguienteNivel.ToString();
		experiencia.text = "EXP - " + pokemon.experienciaActual + "/" + atexto;
		experiencia.enabled = true;

	}

}
