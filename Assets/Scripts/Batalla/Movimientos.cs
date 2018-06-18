using UnityEngine;

[CreateAssetMenu(fileName = "Movimientos", menuName = "Batalla/Movimientos")]
public class Movimientos : ScriptableObject {


	public string Nombre;
	public int Potencia;
	public int Precision;
	public int PP;
	public string Tipo;
	public bool Ofensivo;
	public bool AtaqueEspecial;

}
