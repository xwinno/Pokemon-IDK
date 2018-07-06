using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerManagement : MonoBehaviour {
	
#region Variables
	
	public static PlayerManagement instance;

	//Variables Sistema Movimiento
	Rigidbody RPlayer;
	CapsuleCollider CPlayer;
	float InputX;
	float InputY;
	float Velocidad = 1.5f;
	public bool BattleMode = false;
	public bool Run;
	public float JumpForce = 5;
	public float FuerzaCaida = 2.5f;
	public LayerMask TierraLayers;

	//Variables Generales
	public AudioSource Music;
	public GameObject PlayerScripts;

	//Variables Animaciones
	public Animator PlayerAnim;
	public GameObject DanceCamera;
	public int pokemonCount = 0;

#endregion

#region Sistema Movimiento

	//Comprobar si el jugador esta en el suelo
	bool EnTierra()
	{
		return Physics.CheckCapsule(CPlayer.bounds.center, new Vector3(CPlayer.bounds.center.x, CPlayer.bounds.min.y, 
		CPlayer.bounds.center.z), CPlayer.radius * .9f, TierraLayers); 
		
	}

#endregion

#region  Sistema Animaciones

	//Controla las animaciones
	void PlayerAnimations()
	{
		PlayerAnim.SetFloat("InputX", InputX);
		PlayerAnim.SetFloat("InputY", InputY);
	}


#endregion

	// Use this for initialization
	void Awake () 
	{
		CPlayer = GetComponent<CapsuleCollider>();
		RPlayer = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () 
	{
		//Sistema Animaciones
		InputX = Input.GetAxis("Horizontal");
		InputY = Input.GetAxis("Vertical");

		//Lanzar Pokeball
		if(Input.GetKeyDown(KeyCode.R) && pokemonCount == 0)
		{
			PlayerAnim.SetTrigger("LanzarPokeball");
			pokemonCount = 1;
		}

		if(Input.GetKeyDown(KeyCode.Alpha2))
		{
			var TemporalSlot = EquipoPokemon.instance.equipoPokemon[0];
			EquipoPokemon.instance.equipoPokemon[0] = EquipoPokemon.instance.equipoPokemon[1];
			EquipoPokemon.instance.equipoPokemon[1] = TemporalSlot;
			EquipoPokemon.instance.AlCambiarPokemonLlamada.Invoke();
		}

		if(Input.GetKeyDown(KeyCode.Alpha3))
		{
			var TemporalSlot = EquipoPokemon.instance.equipoPokemon[0];
			EquipoPokemon.instance.equipoPokemon[0] = EquipoPokemon.instance.equipoPokemon[2];
			EquipoPokemon.instance.equipoPokemon[2] = TemporalSlot;
			EquipoPokemon.instance.AlCambiarPokemonLlamada.Invoke();
		}

		if(Input.GetKeyDown(KeyCode.Alpha4))
		{
			var TemporalSlot = EquipoPokemon.instance.equipoPokemon[0];
			EquipoPokemon.instance.equipoPokemon[0] = EquipoPokemon.instance.equipoPokemon[3];
			EquipoPokemon.instance.equipoPokemon[3] = TemporalSlot;
			EquipoPokemon.instance.AlCambiarPokemonLlamada.Invoke();
		}

		if(Input.GetKeyDown(KeyCode.Alpha5))
		{
			var TemporalSlot = EquipoPokemon.instance.equipoPokemon[0];
			EquipoPokemon.instance.equipoPokemon[0] = EquipoPokemon.instance.equipoPokemon[4];
			EquipoPokemon.instance.equipoPokemon[4] = TemporalSlot;
			EquipoPokemon.instance.AlCambiarPokemonLlamada.Invoke();
		}

		if(Input.GetKeyDown(KeyCode.Alpha6))
		{
			var TemporalSlot = EquipoPokemon.instance.equipoPokemon[0];
			EquipoPokemon.instance.equipoPokemon[0] = EquipoPokemon.instance.equipoPokemon[5];
			EquipoPokemon.instance.equipoPokemon[5] = TemporalSlot;
			EquipoPokemon.instance.AlCambiarPokemonLlamada.Invoke();
		}

		//Llamadas
		PlayerAnimations();
	}

	void FixedUpdate()
	{
		//Sistema Movimiento - 2
		
		if(BattleMode == false)
		{
		
			transform.Translate(Velocidad*Input.GetAxis("Horizontal")*Time.deltaTime,0f,Velocidad*Input.GetAxis("Vertical")*Time.deltaTime);

			if(EnTierra() && Input.GetKeyDown(KeyCode.Space))
			{
				PlayerAnim.SetTrigger("Jump");
				RPlayer.AddForce(Vector3.up * JumpForce);
			}

			if(Input.GetKey(KeyCode.LeftShift))
			{
				Velocidad = 5;
				PlayerAnim.SetBool("Run", true);
				Run = true;
			}

			else if(Input.GetKey(KeyCode.LeftShift) && Input.GetKeyDown(KeyCode.R))
			{
				Velocidad = 5;
				PlayerAnim.SetBool("Run", true);
				Run = true;
			}

			if(Input.GetKeyUp(KeyCode.LeftShift))
			{
				Velocidad = 2;
				PlayerAnim.SetBool("Run", false);
				Run = false;
			}

			if(Input.GetKeyUp(KeyCode.LeftShift) && Input.GetKeyDown(KeyCode.R))
			{
				Velocidad = 2;
				PlayerAnim.SetBool("Run", false);
				Run = false;
			}
		}
	}

}
