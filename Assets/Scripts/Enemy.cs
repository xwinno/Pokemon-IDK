using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {

	public GameObject PokemonEnemigo;
	public static Enemy instance;


	void Start () 
	{
		PokemonEnemigo = this.gameObject;
	}
	
	void Update () 
	{
		
	}
}
