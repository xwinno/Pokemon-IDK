using UnityEngine;
using UnityEngine.UI;
using UnityEditor;

public class Stats : MonoBehaviour {


	//Variables

	public PokemonData pokemon;
	public string nombre;
	public int nivel;
	public float experienciaActual;
	public int hpTotal;
	public int ataqueTotal;
	public int ataqueEspecialTotal;
	public int defensaTotal;
	public int defensaEspecialTotal;
	public int velocidadTotal;
	public Movimientos Mov1;
	public Movimientos Mov2;
	public Movimientos Mov3;
	public Movimientos Mov4;

	void Awake()
	{
			calcularHP();
			calcularAtaque();
			calcularAtaqueEspecial();
			calcularDefensa();
			calcularDefensaEspecial();
			calcularVelocidad();
			
			nombre = pokemon.nombre;
			Mov1 = pokemon.movimientos[0];
			Mov2 = pokemon.movimientos[1];
			Mov3 = pokemon.movimientos[2];
			Mov4 = pokemon.movimientos[3];
	}

	void calcularHP()
	{
		var B = pokemon.salud;
		var L = pokemon.nivel;

		//To add IV and Nature and EV
		hpTotal = ((2 * B + 31 + 255) * L / 100 + L + 10);

		pokemon.salud = hpTotal;
	}

	void calcularAtaque()
	{
		var B = pokemon.ataque;
		var L = pokemon.nivel;

		//To add IV and Nature and EV
		ataqueTotal = (((2 * B + 31 + 255) * L / 100 + 5));
	}

	void calcularAtaqueEspecial()
	{
		var B = pokemon.ataqueEspecial;
		var L = pokemon.nivel;

		//To add IV and Nature and EV
		ataqueEspecialTotal = (((2 * B + 31 + 255) * L / 100 + 5));
	}

	void calcularDefensa()
	{
		var B = pokemon.defensa;
		var L = pokemon.nivel;

		//To add IV and Nature and EV
		defensaTotal = (((2 * B + 31 + 255) * L / 100 + 5));
	}

	void calcularDefensaEspecial()
	{
		var B = pokemon.defensaEspecial;
		var L = pokemon.nivel;

		//To add IV and Nature and EV
		defensaEspecialTotal = (((2 * B + 31 + 255) * L / 100 + 5));
	}

	void calcularVelocidad()
	{
		var B = pokemon.velocidad;
		var L = pokemon.nivel;

		//To add IV and Nature and EV
		velocidadTotal = (((2 * B + 31 + 255) * L / 100 + 5));
	}
}
