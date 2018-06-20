using UnityEngine;
using UnityEngine.UI;

public class Stats : MonoBehaviour {

	public PokemonData pokemon;
	public int hpTotal;

	void Start()
	{
		calcularHP();
	}

	void calcularHP()
	{
		var B = pokemon.salud;
		var L = pokemon.nivel;

		hpTotal = (((B + 31) * 2 + (9 / 4)) * L / 100) + L + 10;
	}
}
