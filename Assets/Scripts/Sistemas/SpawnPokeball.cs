using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPokeball : MonoBehaviour {

	public GameObject SpawnBaller;
	public GameObject Pokeball;

	public void SpawnBall()
	{

		Instantiate(Pokeball, SpawnBaller.transform.position, Quaternion.identity);
	}

}
