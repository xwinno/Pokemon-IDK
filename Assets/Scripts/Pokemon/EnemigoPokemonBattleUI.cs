using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemigoPokemonBattleUI : MonoBehaviour {

	public Image icon;
	public Text nombre;
	public Text vida;
	public Text experiencia;
	public float siguienteNivel;
	public PokemonBattle PokemonRival;
	public GameObject MenuPokemon;
	public static EnemigoPokemonBattleUI instance;
	void Start()
	{
		PokemonRival = this.gameObject.GetComponent<PokemonBattle>();
		MenuPokemon.SetActive(false);
		icon.sprite = PokemonRival.pokemon.icon;
		nombre.text = PokemonRival.pokemon.nombre;
		vida.text = "HP - " + PokemonRival.HP + "/" + PokemonRival.pokemon.salud;
		
	}

	void Update()
	{
		vida.text = "HP - " + PokemonRival.HP + "/" + PokemonRival.pokemon.salud;
	}
}
