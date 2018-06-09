using UnityEngine;

public class Interactivo : MonoBehaviour {

	public float radio = 4f;
	public Transform PuntoInteractuable;
	public Transform Player;

	public virtual void Interactuar ()
	{
		//Define el tipo de interaccion
		Debug.Log("Interactuando con " + transform.name);
	}

	void Update()
	{

		float distancia = Vector3.Distance(Player.transform.position, PuntoInteractuable.position);

		if(Input.GetKeyDown(KeyCode.E) && distancia <= radio)
		{
			Interactuar();
		}

	}

	void OnDrawGizmos()
	{

		if (PuntoInteractuable == null)
		{
			PuntoInteractuable = transform;
		}

		Gizmos.color = Color.blue;
		Gizmos.DrawWireSphere(PuntoInteractuable.position, radio);
	}

}
