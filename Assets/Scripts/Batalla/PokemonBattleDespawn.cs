using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PokemonBattleDespawn : MonoBehaviour {
	public GameObject AdministradorScripts;

	void Awake()
	{
		AdministradorScripts = GameObject.FindGameObjectWithTag("Administrador");
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (AdministradorScripts.GetComponent<SistemaBatalla>().Despawn == true)
		{
			Destroy(this.gameObject);
		}
	}
}
