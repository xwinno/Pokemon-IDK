using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PokemonBattle : MonoBehaviour {

	public PokemonData pokemon;
	public int HP;
	public	int Ataque;
	public int Defensa;

	// Use this for initialization
	void Start () 
	{
		HP = pokemon.salud;
		Ataque = pokemon.ataque;
		Defensa = pokemon.defensa;
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (HP <= 0)
		{
			Destroy(gameObject);
		}
	}
}
