using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamaraToTercera : MonoBehaviour {

	public GameObject ThirdCamera;
	public GameObject ElegirPokemonCamara;
	public GameObject PlayerScripts;
	public bool estadoCamaraTercera = false;

	void Awake()
	{
		PlayerScripts.GetComponent<PlayerManagement>().enabled = false;
		ThirdCamera.GetComponent<CameraController>().enabled = false;
	}

	public void ActivaTercera()
	{
			ThirdCamera.SetActive(true);
			PlayerScripts.GetComponent<PlayerManagement>().enabled = true;
			ThirdCamera.GetComponent<CameraController>().enabled = true;
			ElegirPokemonCamara.SetActive(false);
			estadoCamaraTercera = true;
	}
}
