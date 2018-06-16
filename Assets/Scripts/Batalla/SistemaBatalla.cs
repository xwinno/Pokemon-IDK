using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SistemaBatalla : MonoBehaviour {

	
	public Text Movimiento1;
	public Text Movimiento2;
	public Text Movimiento3;
	public Text Movimiento4;
	public GameObject BackgroundBatalla;
	public GameObject BackgroundMovimientos;
	public PokemonBattle PokemonRival;
	public IniciarBatallaLegendarios MusicaBatalla;
	public GameObject PlayerScripts;
	public int Daño;
	bool Movimientos;
	
	
	public void EncenderMovimientos()
	{
		var movimiento = EquipoPokemon.instance.pokemons[0];

		BackgroundBatalla.SetActive(false);
		BackgroundMovimientos.SetActive(true);
		Movimientos = true;
		
		if (movimiento.movimientos[0] != null)
		{
			Movimiento1.text = movimiento.movimientos[0].Nombre.ToString();
		}
		
		if (movimiento.movimientos[1] != null)
		{
			Movimiento2.text = movimiento.movimientos[1].Nombre.ToString();
		}
		
		if (movimiento.movimientos[2] != null)
		{
			Movimiento3.text = movimiento.movimientos[2].Nombre.ToString();
		}

		if (movimiento.movimientos[3] != null)
		{
			Movimiento4.text = movimiento.movimientos[3].Nombre.ToString();
		}
	}

	void Update()
	{
		if (Input.GetKeyDown(KeyCode.Escape) && Movimientos == true)
		{
			BackgroundBatalla.SetActive(true);
			BackgroundMovimientos.SetActive(false);
			Movimientos = false;
		}
	}

	public void Huir()
	{	
		MusicaBatalla = Object.FindObjectOfType<IniciarBatallaLegendarios>();
		BackgroundBatalla.SetActive(false);
		MusicaBatalla.BattleMusic.Stop();
		PlayerScripts.GetComponent<PlayerManagement>().BattleMode = false;
	}
	public void Movi1()
	{
		var movimiento = EquipoPokemon.instance.pokemons[0];
		PokemonRival = Object.FindObjectOfType<PokemonBattle>();
		Daño = movimiento.movimientos[0].Daño;
		PokemonRival.HP -= Daño;
	}

}
