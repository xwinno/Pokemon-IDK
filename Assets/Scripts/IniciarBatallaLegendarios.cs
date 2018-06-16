using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IniciarBatallaLegendarios : MonoBehaviour {

	public GameObject PlayerScripts;
	public GameObject CloseCameraEnemy;
	public GameObject CloseCameraTeam;
	public GameObject ThirdPerson;
	public AudioSource BattleMusic;
	public GameObject Background;
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
			BattleMusic.Play();
			Background.SetActive(true);
		}
	}
	void OnDrawGizmos()
	{
		Gizmos.color = Color.blue;
		Gizmos.DrawWireSphere(transform.position, RadioVisible);
	}
}
