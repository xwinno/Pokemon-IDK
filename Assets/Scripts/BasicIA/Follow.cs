using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Follow : MonoBehaviour {

	public GameObject PokemonTransform;
	public Transform Target;
	public Animator Pokemon;
	public float Velocidad = 1.5f;
	public float VelocidadR = 4f;
	public float MinDistance = 2f;
	public bool Run;

	// Use this for initialization
	void Start () 
	{
		Run = false;
	}
	
	// Update is called once per frame
	void Update () 
	{
		transform.LookAt(Target);

		if(Vector3.Distance(transform.position,Target.position) >= MinDistance && Run == false)
		{
			transform.position += transform.forward * Velocidad * Time.deltaTime;
			
			Pokemon.SetBool("Idle", false);
			Pokemon.SetBool("Run", false);
			Pokemon.SetBool("Walk", true);
		}

		else if(Vector3.Distance(transform.position,Target.position) >= MinDistance && Run == true)
		{
			transform.position += transform.forward * VelocidadR * Time.deltaTime;

			Pokemon.SetBool("Idle", false);
			Pokemon.SetBool("Run", true);
			Pokemon.SetBool("Walk", false);
		}

		if(Vector3.Distance(transform.position,Target.position) <= MinDistance && Run == false)
		{
			Pokemon.SetBool("Idle", true);
			Pokemon.SetBool("Run", false);
			Pokemon.SetBool("Walk", false);
		}
	}
}
