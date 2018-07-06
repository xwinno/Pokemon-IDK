using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattleIA : MonoBehaviour {

	public PokemonData pokemon;

	void Think()
	{
		if(EquipoPokemon.instance.equipoPokemon[0].modelo.GetComponent<Stats>().hpTotal == 10)
		{

		}
	}

}
