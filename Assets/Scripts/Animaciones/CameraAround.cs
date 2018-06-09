using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraAround : MonoBehaviour {

	public Transform Target;
	public float Velocidad;
	
	
	// Use this for initialization
	void Start () 
	{
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		transform.LookAt(Target);
		transform.RotateAround(Target.position, Vector3.up, Velocidad * Time.deltaTime);
	}
}
