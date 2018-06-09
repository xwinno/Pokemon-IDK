using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SistemaTiendas : MonoBehaviour {

#region Variables
	public GameObject PlayerScript;
	public GameObject StoreUI;
	public GameObject Punch;
	public bool PunchUnlocked;
	public bool PunchAvalible;

#endregion
	
	// Use this for initialization
	void Awake () 
	{
		PunchAvalible = true;
	}

	void Update()
	{
		
	}

#region Sistema Tiendas

	//Abre la tienda al colisionar
	void OnTriggerEnter (Collider other)
	{
		if (other.gameObject.CompareTag("Store"))
		{
			Store();
		}
	}

	//Pausa el juego y activa la tienda
	void Store()
	{
		StoreUI.SetActive(true);
		PauseGame();
		
		if (PunchAvalible == true)
		{
			Punch.SetActive(true);
		}
	}

#endregion

#region Contenido Tienda

	//Compra cosas en la tienda
	public void BuyPunch()
	{
		if (PlayerScript.GetComponent<PlayerManagement>().Monedas >= 8)
		{			
			PlayerScript.GetComponent<PlayerManagement>().Monedas -= 8;
			PunchUnlocked = true;
			StoreUI.SetActive(false);
			Punch.SetActive(false);
			ResumeGame();
		}

		else if (PlayerScript.GetComponent<PlayerManagement>().Monedas < 8)
		{
			StoreUI.SetActive(false);
			Punch.SetActive(false);
			ResumeGame();
		}

	}

#endregion

#region Pause/Resume Game

	//Pause/Resume Game
	void PauseGame()
	{
		Time.timeScale = 0;
	}

	void ResumeGame()
	{
		Time.timeScale = 1;
	}

#endregion

}
