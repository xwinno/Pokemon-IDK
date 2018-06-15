using UnityEngine;

[CreateAssetMenu(fileName = "Movimientos", menuName = "Batalla/Movimientos")]
public class Movimientos : ScriptableObject {


	public string Nombre;
	public int Daño;
	public int Precision;
	public int PP;
	public string Tipo;


	public virtual void Atacar()
	{
		var Enemigo = Enemy.instance.PokemonEnemigo.GetComponent<PokemonBattle>();
		Enemigo.HP -= Daño;
	}

}
