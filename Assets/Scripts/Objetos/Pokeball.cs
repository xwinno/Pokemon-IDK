using UnityEngine;

public class Pokeball : MonoBehaviour {

	public float radio = 0.5f;

	void OnDrawGizmos()
	{
		Gizmos.color = Color.blue;
		Gizmos.DrawWireSphere(transform.position, radio);
	}
}
