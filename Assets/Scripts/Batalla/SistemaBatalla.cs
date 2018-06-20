using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SistemaBatalla : MonoBehaviour {

	
	public Text Movimiento1;
	public Text Movimiento2;
	public Text Movimiento3;
	public Text Movimiento4;
	public Image icono;
	public Text nombre;
	public Text vida;
	public Text experiencia;
	public GameObject BackgroundBatalla;
	public GameObject BackgroundMovimientos;
	public GameObject BatallaPokemonUI;
	public PokemonBattle PokemonRival;
	public IniciarBatalla MusicaBatalla;
	public GameObject PlayerScripts;
	public GameObject GeneralCamera;
	public GameObject ThirdCamera;
	public int Potencia;
	public bool Despawn;
	public int HP;
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

		UpdateUI();

	}

	void LateUpdate()
	{
		Despawn = false;
	}

	void UpdateUI()
	{
		if(EquipoPokemon.instance.pokemons.Count != 0)
		{
			HP = EquipoPokemon.instance.pokemons[0].salud;
			icono.sprite = EquipoPokemon.instance.pokemons[0].icon;
			nombre.text = EquipoPokemon.instance.pokemons[0].nombre;
			vida.text = "HP - " + HP + "/" + EquipoPokemon.instance.pokemons[0].salud;
			
			var LevelUp = EquipoPokemon.instance.pokemons[0].nivel + 1;
			
		if(LevelUp < 100)
		{
			var siguienteNivel = (6 * (Mathf.Pow(LevelUp,3)) / 5  - 15 * (Mathf.Pow(LevelUp, 2)) + 100 * (LevelUp) - 140);
			var atexto = siguienteNivel.ToString();
			experiencia.text = "EXP - " + EquipoPokemon.instance.pokemons[0].experienciaActual + "/" + atexto;
		}
			
		}
	}

	public void Huir()
	{	
		MusicaBatalla = Object.FindObjectOfType<IniciarBatalla>();
		Despawn = true;
		GeneralCamera.GetComponent<Camera>().enabled = false;
		ThirdCamera.GetComponent<Camera>().enabled = true;
		ThirdCamera.GetComponent<CameraController>().enabled = true;
		BackgroundBatalla.SetActive(false);
		BatallaPokemonUI.SetActive(false);
		MusicaBatalla.BattleMusic.Stop();
		PlayerScripts.GetComponent<PlayerManagement>().BattleMode = false;
	}
	public void Movi1()
	{
		var movimiento = EquipoPokemon.instance.pokemons[0];

		if (movimiento.movimientos[0].Ofensivo == true && movimiento.movimientos[0].AtaqueEspecial == false)
		{
			AtaqueFisico1();
		}

		if (movimiento.movimientos[0].Ofensivo == true && movimiento.movimientos[0].AtaqueEspecial == true)
		{
			AtaqueEspecial1();
		}
	}

	void AtaqueFisico1()
	{
		var movimiento = EquipoPokemon.instance.pokemons[0];
		PokemonRival = Object.FindObjectOfType<PokemonBattle>();

		var PokemonPlayer = GameObject.FindObjectOfType<PokemonBattleDespawn>();
		var Daño = (movimiento.nivel * movimiento.ataque * movimiento.movimientos[0].Potencia) / (25 * PokemonRival.Defensa + 2);

		PokemonPlayer.GetComponent<Animator>().SetTrigger("AtaqueFis1");
		PokemonRival.HP -= Mathf.RoundToInt(Daño);
		Debug.Log(Daño);
	}

	void AtaqueEspecial1()
	{
		var movimiento = EquipoPokemon.instance.pokemons[0];
		PokemonRival = Object.FindObjectOfType<PokemonBattle>();

		var PokemonPlayer = GameObject.FindObjectOfType<PokemonBattleDespawn>();
		var Daño = (movimiento.nivel * movimiento.ataqueEspecial * movimiento.movimientos[0].Potencia) / (25 * PokemonRival.DefensaEspecial + 2);

		PokemonPlayer.GetComponent<Animator>().SetTrigger("AtaqueEsp1");
		PokemonRival.HP -= Mathf.RoundToInt(Daño);
		Debug.Log(Daño);
	}

	public void Movi2()
	{
		var movimiento = EquipoPokemon.instance.pokemons[0];
		PokemonRival = Object.FindObjectOfType<PokemonBattle>();
		
		if (movimiento.movimientos[1].Ofensivo == true && movimiento.movimientos[1].AtaqueEspecial == false)
		{
			AtaqueFisico2();
		}

		if (movimiento.movimientos[1].Ofensivo == true && movimiento.movimientos[1].AtaqueEspecial == true)
		{
			AtaqueEspecial2();
		}
	}

	void AtaqueFisico2()
	{
		var movimiento = EquipoPokemon.instance.pokemons[0];
		PokemonRival = Object.FindObjectOfType<PokemonBattle>();

		var PokemonPlayer = GameObject.FindObjectOfType<PokemonBattleDespawn>();
		var Daño = (movimiento.nivel * movimiento.ataque * movimiento.movimientos[1].Potencia) / (25 * PokemonRival.Defensa + 2);
		
		PokemonPlayer.GetComponent<Animator>().SetTrigger("AtaqueFis1");
		PokemonRival.HP -= Mathf.RoundToInt(Daño);
		Debug.Log(Daño);
	}

	void AtaqueEspecial2()
	{
		var movimiento = EquipoPokemon.instance.pokemons[0];
		PokemonRival = Object.FindObjectOfType<PokemonBattle>();
		
		var PokemonPlayer = GameObject.FindObjectOfType<PokemonBattleDespawn>();
		var Daño = (movimiento.nivel * movimiento.ataqueEspecial * movimiento.movimientos[1].Potencia) / (25 * PokemonRival.DefensaEspecial + 2);
		
		PokemonPlayer.GetComponent<Animator>().SetTrigger("AtaqueEsp1");
		PokemonRival.HP -= Mathf.RoundToInt(Daño);
		Debug.Log(Daño);
	}

	public void Movi3()
	{
		var movimiento = EquipoPokemon.instance.pokemons[0];
		PokemonRival = Object.FindObjectOfType<PokemonBattle>();
		
		if (movimiento.movimientos[2].Ofensivo == true && movimiento.movimientos[2].AtaqueEspecial == false)
		{
			AtaqueFisico3();
		}

		if (movimiento.movimientos[2].Ofensivo == true && movimiento.movimientos[2].AtaqueEspecial == true)
		{
			AtaqueEspecial3();
		}
	}

	void AtaqueFisico3()
	{	
		var movimiento = EquipoPokemon.instance.pokemons[0];
		PokemonRival = Object.FindObjectOfType<PokemonBattle>();

		var PokemonPlayer = GameObject.FindObjectOfType<PokemonBattleDespawn>();
		var Daño = (movimiento.nivel * movimiento.ataque * movimiento.movimientos[2].Potencia) / (25 * PokemonRival.Defensa + 2);
		
		PokemonPlayer.GetComponent<Animator>().SetTrigger("AtaqueFis1");
		PokemonRival.HP -= Mathf.RoundToInt(Daño);
		Debug.Log(Daño);
	}

	void AtaqueEspecial3()
	{
		var movimiento = EquipoPokemon.instance.pokemons[0];
		PokemonRival = Object.FindObjectOfType<PokemonBattle>();

		var PokemonPlayer = GameObject.FindObjectOfType<PokemonBattleDespawn>();
		var Daño = (movimiento.nivel * movimiento.ataqueEspecial * movimiento.movimientos[2].Potencia) / (25 * PokemonRival.DefensaEspecial + 2);
		
		PokemonPlayer.GetComponent<Animator>().SetTrigger("AtaqueEsp1");
		PokemonRival.HP -= Mathf.RoundToInt(Daño);
		Debug.Log(Daño);
	}

	public void Movi4()
	{
		var movimiento = EquipoPokemon.instance.pokemons[0];
		PokemonRival = Object.FindObjectOfType<PokemonBattle>();
		
		if (movimiento.movimientos[3].Ofensivo == true && movimiento.movimientos[3].AtaqueEspecial == false)
		{
			AtaqueFisico4();
		}

		if (movimiento.movimientos[3].Ofensivo == true && movimiento.movimientos[3].AtaqueEspecial == true)
		{
			AtaqueEspecial4();
		}
	}

	void AtaqueFisico4()
	{

		var movimiento = EquipoPokemon.instance.pokemons[0];
		PokemonRival = Object.FindObjectOfType<PokemonBattle>();

		var PokemonPlayer = GameObject.FindObjectOfType<PokemonBattleDespawn>();
		var Daño = (movimiento.nivel * movimiento.ataque * movimiento.movimientos[3].Potencia) / (25 * PokemonRival.Defensa + 2);
		
		PokemonPlayer.GetComponent<Animator>().SetTrigger("AtaqueFis1");
		PokemonRival.HP -= Mathf.RoundToInt(Daño);
		Debug.Log(Daño);

	}

	void AtaqueEspecial4()
	{
		var movimiento = EquipoPokemon.instance.pokemons[0];
		PokemonRival = Object.FindObjectOfType<PokemonBattle>();

		var PokemonPlayer = GameObject.FindObjectOfType<PokemonBattleDespawn>();
		var Daño = (movimiento.nivel * movimiento.ataqueEspecial * movimiento.movimientos[3].Potencia) / (25 * PokemonRival.DefensaEspecial + 2);
		PokemonPlayer.GetComponent<Animator>().SetTrigger("AtaqueEsp1");
		PokemonRival.HP -= Mathf.RoundToInt(Daño);
		Debug.Log(Daño);
	}
}
