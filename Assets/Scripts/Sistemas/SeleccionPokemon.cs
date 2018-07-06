using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeleccionPokemon : Interactivo {

#region Variables

	public GameObject Prefabs;
	public GameObject PlayerScripts;
	public GameObject ChoiseTwo;
	public Material[] EeveeSelected;
	public Material[] EeveeOriginal;
	public Material[] PikachuSelected;
	public Material[] PikachuOriginal;
	public AudioSource PikachuSound;
	public AudioSource EeveeSound;
	public Animator ElegirPokemon;
	public PokemonData pokemon;
	public PokemonData pokemon2;
	public bool EeeveeChoose;
	public bool PikachuChoose;

#endregion

	void Awake()
	{
		this.gameObject.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
		ChoiseTwo.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
	}

	// Use this for initialization
	void Start () 
	{
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		
		if(Input.GetKeyDown(KeyCode.A))
		{
			EeveeActive();
			PikachuNormal();
			
			PikachuChoose = false;
			EeeveeChoose = true;
		}

		else if(Input.GetKeyDown(KeyCode.D))
		{
			EeveeNormal();
			PikachuActive();

			EeeveeChoose = false;
			PikachuChoose = true;
		}

		if(Input.GetKeyDown(KeyCode.E) && EeeveeChoose == true)
		{
			//Cambia el shader al normal
			EeveeNormal();
			this.gameObject.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeRotation;
			//Ejecuta su grito
			EeveeSound.Play();

			//Añades a tu equipo al elegido
			Debug.Log("Adquieres " + pokemon.name);
            EquipoPokemon.instance.Añadir(pokemon);
			Stats.instance.calcularHP();
			Prefabs.GetComponent<AdministradorPrefabs>().Prefabs[0].GetComponent<LanzarPokeball>().pokemon = pokemon;

			//Mover Camara
			ElegirPokemon.SetTrigger("ATerceraPersona");
			this.gameObject.SetActive(false);
		}

		else if (Input.GetKeyDown(KeyCode.E) && PikachuChoose == true)
		{
			//Cambia el shader al normal
			PikachuNormal();
			ChoiseTwo.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeRotation;
			//Ejecuta su grito
			PikachuSound.Play();
			
			//Añades a tu equipo al elegido
			Debug.Log("Adquieres " + pokemon2.name);
            EquipoPokemon.instance.Añadir(pokemon2);
			Stats.instance.calcularHP();
			Prefabs.GetComponent<AdministradorPrefabs>().Prefabs[0].GetComponent<LanzarPokeball>().pokemon = pokemon2;
			this.gameObject.GetComponent<SeleccionPokemon>().enabled = false;

			//Mover Camara
			ElegirPokemon.SetTrigger("ATerceraPersona");
			ChoiseTwo.gameObject.SetActive(false);
		}
	}

	void EeveeNormal()
	{
		Material[] Eevee = this.gameObject.GetComponent<Renderer>().materials;
		Eevee[0] = EeveeOriginal[0];
		Eevee[1] = EeveeOriginal[1];
		Eevee[2] = EeveeOriginal[2];
		this.gameObject.GetComponent<Renderer>().materials = Eevee;
	}

	void EeveeActive()
	{
		Material[] Eevee = this.gameObject.GetComponent<Renderer>().materials;
		Eevee[0] = EeveeSelected[0];
		Eevee[1] = EeveeSelected[1];
		Eevee[2] = EeveeSelected[2];
		this.gameObject.GetComponent<Renderer>().materials = Eevee;
	}

	
	void PikachuNormal()
	{
		Material[] Pikachu = ChoiseTwo.gameObject.GetComponent<Renderer>().materials;
		Pikachu[0] = PikachuOriginal[0];
		Pikachu[1] = PikachuOriginal[1];
		Pikachu[2] = PikachuOriginal[3];
		Pikachu[3] = PikachuOriginal[2];
		ChoiseTwo.gameObject.GetComponent<Renderer>().materials = Pikachu;
	}

	void PikachuActive()
	{
		Material[] Pikachu = ChoiseTwo.gameObject.GetComponent<Renderer>().materials;
		Pikachu[0] = PikachuSelected[0];
		Pikachu[1] = PikachuSelected[1];
		Pikachu[2] = PikachuSelected[3];
		Pikachu[3] = PikachuSelected[2];
		ChoiseTwo.gameObject.GetComponent<Renderer>().materials = Pikachu;
	}
}
