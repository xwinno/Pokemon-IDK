using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

[System.Serializable]
public class SaveEvent : MonoBehaviour {

	public GameObject elegirPokemonCamera;
	public GameObject eevee;
	public GameObject pikachu;
	string filePath;
	string readCameraTercera;

	void Awake()
	{
		filePath = Application.dataPath + "/SaveData/CameraTercera.json";
		readCameraTercera = File.ReadAllText(filePath);
	}

	public void SaveCameraData()
	{
		CameraData CamaraTercera = JsonUtility.FromJson<CameraData>(readCameraTercera);
		var estadoCamara = elegirPokemonCamera.GetComponent<CamaraToTercera>();
		var eeveeChoose = eevee.GetComponent<SeleccionPokemon>();

		CamaraTercera.estadoCamaraTercera = estadoCamara.estadoCamaraTercera;
		CamaraTercera.EeveeChoose = eeveeChoose.EeeveeChoose;
		CamaraTercera.PikachuChoose = eeveeChoose.PikachuChoose;

		var SaveCameraTercera = JsonUtility.ToJson(CamaraTercera);
		File.WriteAllText(filePath, SaveCameraTercera);
	}

	public void LoadCameraData()
	{
		CameraData CamaraTercera = JsonUtility.FromJson<CameraData>(readCameraTercera);
		var estadoCamara = elegirPokemonCamera.GetComponent<CamaraToTercera>();
		var eeveeChoose = eevee.GetComponent<SeleccionPokemon>();

		estadoCamara.estadoCamaraTercera = CamaraTercera.estadoCamaraTercera;
		eeveeChoose.EeeveeChoose = CamaraTercera.EeveeChoose;
		eeveeChoose.PikachuChoose = CamaraTercera.PikachuChoose;

		if(estadoCamara.estadoCamaraTercera == true && eeveeChoose.EeeveeChoose == true)
		{
			estadoCamara.ActivaTercera();
			eevee.SetActive(false);
		}
		
		else if(estadoCamara.estadoCamaraTercera == true && eeveeChoose.PikachuChoose == true)
		{
			estadoCamara.ActivaTercera();
			eeveeChoose.enabled = false;
			pikachu.SetActive(false);
		}
	}
}


[System.Serializable]
public class CameraData {

	public bool estadoCamaraTercera;
	public bool EeveeChoose;
	public bool PikachuChoose;
}