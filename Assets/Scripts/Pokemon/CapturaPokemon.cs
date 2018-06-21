using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class CapturaPokemon : Interactivo {

	public PokemonData pokemon;

	public override void Interactuar()
	{
		base.Interactuar();
		Capturar();
	}

	void Capturar()
	{
         bool FueCapturado = EquipoPokemon.instance.Añadir(pokemon);

		if(FueCapturado)
		Destroy(gameObject);
	}
}