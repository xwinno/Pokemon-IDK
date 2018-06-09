using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camara_A_Tercera : MonoBehaviour {

	public GameObject ThirdCamera;
	public GameObject ElegirPokemonCamara;
	public GameObject PlayerScripts;

	void Awake()
	{
		PlayerScripts.GetComponent<PlayerManagement>().enabled = false;
		ThirdCamera.GetComponent<CameraController>().enabled = false;
	}

	void Update()
	{
		
	}

	public void ActivaTercera()
	{
		ThirdCamera.SetActive(true);
		PlayerScripts.GetComponent<PlayerManagement>().enabled = true;
		ThirdCamera.GetComponent<CameraController>().enabled = true;
		ElegirPokemonCamara.SetActive(false);
	}

}
