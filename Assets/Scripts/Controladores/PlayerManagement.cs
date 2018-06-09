using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerManagement : MonoBehaviour {
	
#region Variables

	//Variables Sistema Vida
	public Sprite[] OpcionesVida = new Sprite[6];
	public Image VidasUI;
	int Vidas;
	
	//Variables Sistema Movimiento
	Rigidbody RPlayer;
	CapsuleCollider CPlayer;
	float InputX;
	float InputY;
	float Velocidad = 1.5f;
	public bool BattleMode = false;
	public float JumpForce = 5;
	public float FuerzaCaida = 2.5f;
	public LayerMask TierraLayers;

	//Variables Sistema Monedas
	public int Monedas;
	public Text TextoMonedas;
	public AudioSource CoinSound;

	//Variables Generales
	public AudioSource Music;
	public GameObject PlayerScripts;

	//Variables Animaciones
	public Animator PlayerAnim;
	public GameObject DanceCamera;

#endregion

#region Sistema Movimiento

	//Comprobar si el jugador esta en el suelo
	bool EnTierra()
	{
		return Physics.CheckCapsule(CPlayer.bounds.center, new Vector3(CPlayer.bounds.center.x, CPlayer.bounds.min.y, 
		CPlayer.bounds.center.z), CPlayer.radius * .9f, TierraLayers); 
		
	}

#endregion

#region Sistema Monedas

	//Actualiza la cantidad de monedas que aparecen en la UI
	void UpdateCoins()
	{
		TextoMonedas.text = Monedas.ToString();
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
		Monedas = 0;
		Vidas = 5;
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
		if(Input.GetKeyDown(KeyCode.R))
		{
			PlayerAnim.SetTrigger("LanzarPokeball");
			//ActivaPokemon
		}

		else if (Input.GetKeyDown(KeyCode.R))
		{
			
			//DesctivaPokemon
		}

		//Llamadas
		UpdateCoins();
		PlayerAnimations();
	}

	void LateUpdate()
	{	
		//Representa la vida en la UI	
		if (Vidas == 5)
		{
			VidasUI.sprite = OpcionesVida[5];
		}
		
		if (Vidas == 4)
		{
			VidasUI.sprite = OpcionesVida[4];
		}
		
		if (Vidas == 3)
		{
			VidasUI.sprite = OpcionesVida[3];
		}
		
		if (Vidas == 2)
		{
			VidasUI.sprite = OpcionesVida[2];
		}

		if (Vidas == 1)
		{
			VidasUI.sprite = OpcionesVida[1];
		}
		if (Vidas == 0)
		{
			VidasUI.sprite = OpcionesVida[0];
		}
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
		}

		else if(Input.GetKey(KeyCode.LeftShift) && Input.GetKeyDown(KeyCode.R))
		{
			Velocidad = 5;
			PlayerAnim.SetBool("Run", true);
		}


		if(Input.GetKeyUp(KeyCode.LeftShift))
		{
			Velocidad = 2;
			PlayerAnim.SetBool("Run", false);
		}

		if(Input.GetKeyUp(KeyCode.LeftShift) && Input.GetKeyDown(KeyCode.R))
		{
			Velocidad = 2;
			PlayerAnim.SetBool("Run", false);
		}


		}
	}

}
