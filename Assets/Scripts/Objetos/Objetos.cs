using UnityEngine;


[CreateAssetMenu(fileName = "New Item", menuName = "Inventario/Objetos")]
public class Objeto : ScriptableObject {

	new public string name = "New Item";
	public Sprite icon = null;
	public bool ObjetoBase = false;


}
