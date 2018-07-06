using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IniciarBatalla : MonoBehaviour {

	public GameObject PlayerScripts;
	public GameObject AdministradorJuego;
	public GameObject PositionPlayer;
	public GameObject PlayerMonster;
	public Vector3 PrePosition;
	public Quaternion PreRotation;
	public GameObject CloseCameraEnemy;
	public GameObject CloseCameraTeam;
	public GameObject ThirdPerson;
	public AudioSource BattleMusic;
	public GameObject BatallaPokemonUI;
	public GameObject Background;
	public GameObject PokemonRivalPosition;
	public GameObject GeneralCamera;
	public float RadioVisible = 1.5f;

	// Use this for initialization
	void Start () 
	{

	}
	
	// Update is called once per frame
	void Update () 
	{
		
		float Distancia = Vector3.Distance (PlayerScripts.transform.position, transform.position);
		var ModoBatalla = PlayerScripts.GetComponent<PlayerManagement>();

		if (Distancia <= RadioVisible && (Input.GetKeyDown(KeyCode.E)))
		{
			ModoBatalla.BattleMode = true;
			PrePosition = this.gameObject.transform.position;
			PreRotation = this.gameObject.transform.rotation;
			AdministradorJuego.GetComponent<SistemaBatalla>().Despawn = true;
			PlayerScripts.GetComponent<PlayerManagement>().pokemonCount = 0;
			this.transform.position = PokemonRivalPosition.transform.position;
			this.transform.rotation = PokemonRivalPosition.transform.rotation;
			GeneralCamera.GetComponent<Camera>().enabled = true;
			ThirdPerson.GetComponent<Camera>().enabled = false;
			ThirdPerson.GetComponent<CameraController>().enabled = false;
			PlayerScripts.transform.rotation = PositionPlayer.transform.rotation;
			PlayerScripts.transform.position = PositionPlayer.transform.position;
			
			EquipoPokemon.instance.equipoPokemon[0].modelo.transform.position = PlayerMonster.transform.position;
			EquipoPokemon.instance.equipoPokemon[0].modelo.transform.rotation = PlayerMonster.transform.rotation;
			EquipoPokemon.instance.equipoPokemon[0].modelo.GetComponent<Follow>().enabled = false;
			Instantiate(EquipoPokemon.instance.equipoPokemon[0].modelo);

			this.gameObject.GetComponent<EnemigoPokemonBattleUI>().enabled = true;
			BattleMusic.Play();
			Background.SetActive(true);
			BatallaPokemonUI.SetActive(true);
			Invoke("Spawn",2);
		}
	}
	void OnDrawGizmos()
	{
		Gizmos.color = Color.blue;
		Gizmos.DrawWireSphere(transform.position, RadioVisible);
	}
	void Spawn()
	{
		AdministradorJuego.GetComponent<SistemaBatalla>().Despawn = false;
	}
}
