using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EquipoPokemon : MonoBehaviour {

	public  static EquipoPokemon instance;
	public int espacio = 6;

	public List<PokemonData> pokemons = new List<PokemonData>();

	public delegate void AlCambiarPokemon();
	public AlCambiarPokemon AlCambiarPokemonLlamada;

#region Singlenton


	void Awake()
	{
		if (instance != null)
		{
			Debug.LogWarning("Algo esta mal");
			return;
		}

		instance = this;
	}

#endregion

	public bool Añadir(PokemonData pokemon)
	{
		if(pokemons.Count >= espacio)
		{
			Debug.Log("No tienes espacio para añadir este pokemon");
			return false;
		}
		
		pokemons.Add(pokemon);
		AlCambiarPokemonLlamada.Invoke();
		return true;
	}

	public void Eliminar(PokemonData pokemon)
	{
		pokemons.Remove(pokemon);
		AlCambiarPokemonLlamada.Invoke();
	}

}
