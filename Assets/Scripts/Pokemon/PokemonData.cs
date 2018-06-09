using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Pokemon", menuName = "Equipo/Pokemon")]
public class PokemonData : ScriptableObject {


	public GameObject modelo;
	public Sprite icon;
	public string nombre;
	public string descripcion;
	public int numeroPokedex;
	public float altura;
	public float peso;
	public int nivel;
	public int salud;
	public int ataque;
	public int defensa;
	public int ataqueEspecial;
	public int defensaEspecial;
	public int velocidad;



}
