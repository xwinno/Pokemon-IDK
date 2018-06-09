using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LanzarPokeball : MonoBehaviour {
	
	public float Fuerza;
	public GameObject Player;
	public PokemonData pokemon;

	// Use this for initialization
	void Awake () 
	{
		Player = GameObject.FindGameObjectWithTag("Player");
		this.GetComponent<Rigidbody>().AddForce(Player.transform.forward * Fuerza);
	}


	void OnCollisionEnter(Collision other)
	{
		if(other.gameObject.CompareTag("Tierra"))
		{
			//SpawnPokemon
			EquipoPokemon.instance.pokemons[0].modelo.transform.position = this.gameObject.transform.position;
			Instantiate(EquipoPokemon.instance.pokemons[0].modelo);
			Destroy(this.gameObject);
			
		}
	}
}