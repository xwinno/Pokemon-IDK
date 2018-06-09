using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IniciarBatallaLegendarios : MonoBehaviour {

	public GameObject PlayerScripts;
	public GameObject CloseCameraEnemy;
	public GameObject CloseCameraTeam;
	public GameObject GeneralBattle;
	public GameObject ThirdPerson;
	public AudioSource BattleMusic;
	public float RadioVisible = 1.5f;

	// Use this for initialization
	void Start () 
	{
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		
		float Distancia = Vector3.Distance (PlayerScripts.transform.position, transform.position);

		if (Distancia <= RadioVisible && (Input.GetKeyDown(KeyCode.E)))
		{
			
			ThirdPerson.GetComponent<Camera>().enabled = false;
			CloseCameraEnemy.GetComponent<Camera>().enabled = true;
			BattleMusic.Play();
		}
	}

	void OnCollisionEnter(Collision other)
	{
		if(other.gameObject.CompareTag("Pokeball"))
		{
			ThirdPerson.GetComponent<Camera>().enabled = false;
			CloseCameraEnemy.GetComponent<Camera>().enabled = true;
			BattleMusic.Play();
			Destroy(other.gameObject);
		}
	}

	void OnDrawGizmos()
	{
		Gizmos.color = Color.blue;
		Gizmos.DrawWireSphere(transform.position, RadioVisible);
	}
}
