using UnityEngine;
using UnityEngine.UI;

public class JugadorPokemonBattleUI : MonoBehaviour {

	public Image icon;
	public Text nombre;
	public Text vida;
	public Text experiencia;
	public float siguienteNivel;
	public PokemonBattle PokemonRival;

	void Start()
	{
		PokemonRival = this.gameObject.GetComponent<PokemonBattle>();
		icon.sprite = PokemonRival.pokemon.icon;
		nombre.text = PokemonRival.pokemon.nombre;
		vida.text = "HP - " + PokemonRival.pokemon.salud + "/" + PokemonRival.pokemon.salud;

		var LevelUp = PokemonRival.pokemon.nivel + 1;
		siguienteNivel = (6 * (Mathf.Pow(LevelUp,3)) / 5  - 15 * (Mathf.Pow(LevelUp, 2)) + 100 * (LevelUp) - 140);
		var atexto = siguienteNivel.ToString();
		experiencia.text = "EXP - " + PokemonRival.pokemon.experienciaActual + "/" + atexto;
		experiencia.enabled = true;
	}

}
