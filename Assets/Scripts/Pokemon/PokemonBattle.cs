using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PokemonBattle : MonoBehaviour {

	public PokemonData pokemon;
	public GameObject PlayerScripts;
	public AudioSource BackgroundBatalla;
	public GameObject MovimientosUI;
	public GameObject MenuBatallaUI;
	public GameObject BatallaPokemonUI;
	public GameObject ThirdPerson;
	public GameObject GeneralBatalla;
	public int HP;
	public	int Ataque;
	public int AtaqueEspecial;
	public int Defensa;
	public int DefensaEspecial;

	// Use this for initialization
	void Start () 
	{
		HP = pokemon.salud;
		Ataque = pokemon.ataque;
		AtaqueEspecial = pokemon.ataqueEspecial;
		Defensa = pokemon.defensa;
		DefensaEspecial = pokemon.defensaEspecial;
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (HP <= 0)
		{
			this.gameObject.SetActive(false);
			MenuBatallaUI.SetActive(false);
			MovimientosUI.SetActive(false);
			BatallaPokemonUI.SetActive(false);
			BackgroundBatalla.Stop();
			ThirdPerson.GetComponent<Camera>().enabled = true;
			ThirdPerson.GetComponent<CameraController>().enabled = true;
			GeneralBatalla.GetComponent<Camera>().enabled = false;
			PlayerScripts.GetComponent<PlayerManagement>().BattleMode = false;
		}
	}
}
