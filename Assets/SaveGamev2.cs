using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class SaveGamev2 : MonoBehaviour {

	string filePath;
	string jsonString;

	public List<PokemonData> Database = new List<PokemonData>();

	void Awake()
	{
		filePath = Application.dataPath + "/PlayerSave.json";
		jsonString = File.ReadAllText(filePath);
	}

	public void Save()
	{
		var Equipo = EquipoPokemon.instance.pokemons;
		ListaPokemon listaPokemon = JsonUtility.FromJson<ListaPokemon>(jsonString);

		var PokemonOne = listaPokemon.pokemon.Find(p => p.NombrePokemon == "Pokemon1");


		PokemonOne.NombrePokemon = Equipo[0].nombre;
		PokemonOne.NumeroPokedex = Equipo[0].numeroPokedex - 1;
		jsonString = JsonUtility.ToJson(listaPokemon);
		File.WriteAllText(filePath,jsonString);
	}

	public void Load()
	{
		var Equipo = EquipoPokemon.instance.pokemons;
		Pokemon Pokemon = JsonUtility.FromJson<Pokemon>(jsonString);

		Equipo.Add(Database[Pokemon.NumeroPokedex]);
		EquipoPokemon.instance.AlCambiarPokemonLlamada();
		Debug.Log(Pokemon.NombrePokemon);
		Debug.Log(Pokemon.NumeroPokedex);

	}
}

[System.Serializable]
public class Pokemon {

	public string NombrePokemon;
	public int NumeroPokedex;

}

[System.Serializable]
public class ListaPokemon {
	public List<Pokemon> pokemon;
}