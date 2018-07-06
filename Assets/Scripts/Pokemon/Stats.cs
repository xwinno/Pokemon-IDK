using UnityEngine;
using UnityEngine.UI;
using UnityEditor;
using System.IO;

[System.Serializable]
public class Stats : MonoBehaviour {

	public static Stats instance;

	//Variables
	string filePathOne;
	string readFileOne;
	string filePathTwo;
	string readFileTwo;
	string filePathThird;
	string readFileThird;
	string filePathFourth;
	string readFileFourth;
	string filePathFive;
	string readFileFive;
	string filePathSix;
	string readFileSix;
	public int[] hpTotal;
	public int[] hpActual;
	public int[] ataqueTotal;
	public int[] ataqueEspecialTotal;
	public int[] defensaTotal;
	public int[] defensaEspecialTotal;
	public int[] velocidadTotal;
	public Movimientos Mov1;
	public Movimientos Mov2;
	public Movimientos Mov3;
	public Movimientos Mov4;

	//Check Equipo 0 and this ID.

	void Awake()
	{
		filePathOne = Application.dataPath + "/SaveData/FirstSlotStats.json";
		readFileOne = File.ReadAllText(filePathOne);
		filePathTwo = Application.dataPath + "/SaveData/SecondSlotStats.json";
		readFileTwo = File.ReadAllText(filePathTwo);
		filePathThird = Application.dataPath + "/SaveData/ThirdSlotStats.json";
		readFileThird = File.ReadAllText(filePathThird);
		filePathFourth = Application.dataPath + "/SaveData/FourthSlotStats.json";
		readFileFourth = File.ReadAllText(filePathFourth);
		filePathFive = Application.dataPath + "/SaveData/FiveSlotStats.json";
		readFileFive = File.ReadAllText(filePathFive);
		filePathSix = Application.dataPath + "/SaveData/SixSlotStats.json";
		readFileSix = File.ReadAllText(filePathSix);

		//Singleton
		if (instance != null)
		{
			Debug.LogWarning("Algo esta mal");
			return;
		}

		instance = this;
	}

	void Update()
	{
			//calcularAtaque();
			//calcularAtaqueEspecial();
			//calcularDefensa();
			//calcularDefensaEspecial();
			//calcularVelocidad();
			
			//hpActual = hpTotal;
			//Mov1 = pokemon.movimientos[0];
			//Mov2 = pokemon.movimientos[1];
			//Mov3 = pokemon.movimientos[2];
			//Mov4 = pokemon.movimientos[3];
	}

	public void calcularHP()
	{
		var Equipo = EquipoPokemon.instance.equipoPokemon;
		
		//FirstSlot
		SaveStats FirstSlot = JsonUtility.FromJson<SaveStats>(readFileOne);

		if(Equipo.Count >= 1)
		{
			var B1 = Equipo[0].salud;
			var L1 = Equipo[0].nivel;

			//To add IV and Nature and EV
			hpTotal[0] = ((2 * B1 + 31 + 255) * L1 / 100 + L1 + 10);

			FirstSlot.hpTotal = hpTotal[0];

			var WriteOne = JsonUtility.ToJson(FirstSlot);
			File.WriteAllText(filePathOne, WriteOne);
		}

		//SecondSlot
		SaveStats SecondSlot = JsonUtility.FromJson<SaveStats>(readFileTwo);

		if(Equipo.Count >= 2)
		{
			var B2 = Equipo[1].salud;
			var L2 = Equipo[1].nivel;

			hpTotal[1] = ((2 * B2 + 31 + 255) * L2 / 100 + L2 + 10);

			SecondSlot.hpTotal = hpTotal[1];

			var WriteTwo = JsonUtility.ToJson(SecondSlot);
			File.WriteAllText(filePathTwo, WriteTwo);
		}
		
		//ThirdSlot
		SaveStats ThirdSlot = JsonUtility.FromJson<SaveStats>(readFileThird);

		if(Equipo.Count >= 3)
		{
			var B3 = Equipo[2].salud;
			var L3 = Equipo[2].nivel;

			hpTotal[2] = ((2 * B3 + 31 + 255) * L3 / 100 + L3 + 10);

			ThirdSlot.hpTotal = hpTotal[2];
			
			var WriteThird = JsonUtility.ToJson(ThirdSlot);
			File.WriteAllText(filePathThird, WriteThird);
		}
		
		//FourthSlot
		SaveStats FourthSlot = JsonUtility.FromJson<SaveStats>(readFileFourth);

		if(Equipo.Count >= 4)
		{
			var B4 = Equipo[3].salud;
			var L4 = Equipo[3].nivel;

			hpTotal[3] = ((2 * B4 + 31 + 255) * L4 / 100 + L4 + 10);

			FourthSlot.hpTotal = hpTotal[3];

			var WriteFourth = JsonUtility.ToJson(FourthSlot);
			File.WriteAllText(filePathFourth, WriteFourth);
		}

		//FiveSlot
		SaveStats FiveSlot = JsonUtility.FromJson<SaveStats>(readFileFive);

		if(Equipo.Count >= 5)
		{
			var B5 = Equipo[4].salud;
			var L5 = Equipo[4].nivel;

			hpTotal[4] = ((2 * B5 + 31 + 255) * L5 / 100 + L5 + 10);

			FiveSlot.hpTotal = hpTotal[4];

			var WriteFive = JsonUtility.ToJson(FiveSlot);
			File.WriteAllText(filePathFive, WriteFive);
		}

		//SixSlot
		SaveStats SixSlot = JsonUtility.FromJson<SaveStats>(readFileSix);

		if(Equipo.Count >= 6)
		{
			var B6 = Equipo[5].salud;
			var L6 = Equipo[5].nivel;

			hpTotal[5] = ((2 * B6 + 31 + 255) * L6 / 100 + L6 + 10);

			SixSlot.hpTotal = hpTotal[5];

			var WriteSix = JsonUtility.ToJson(SixSlot);
			File.WriteAllText(filePathSix, WriteSix);
		}
	}

	void calcularAtaque()
	{
		//var B = pokemon.ataque;
		//var L = pokemon.nivel;

		//To add IV and Nature and EV
		//ataqueTotal = (((2 * B + 31 + 255) * L / 100 + 5));
	}

	void calcularAtaqueEspecial()
	{
		//var B = pokemon.ataqueEspecial;
		//var L = pokemon.nivel;

		//To add IV and Nature and EV
		//ataqueEspecialTotal = (((2 * B + 31 + 255) * L / 100 + 5));
	}

	void calcularDefensa()
	{
		//var B = pokemon.defensa;
		//var L = pokemon.nivel;

		//To add IV and Nature and EV
		//defensaTotal = (((2 * B + 31 + 255) * L / 100 + 5));
	}

	void calcularDefensaEspecial()
	{
		//var B = pokemon.defensaEspecial;
		//var L = pokemon.nivel;

		//To add IV and Nature and EV
		//defensaEspecialTotal = (((2 * B + 31 + 255) * L / 100 + 5));
	}

	void calcularVelocidad()
	{
		//var B = pokemon.velocidad;
		//var L = pokemon.nivel;

		//To add IV and Nature and EV
		//velocidadTotal = (((2 * B + 31 + 255) * L / 100 + 5));
	}

	public void SaveStats()
	{
		//Stats
		calcularHP();
	}

	public void LoadStats()
	{
		var Equipo = EquipoPokemon.instance.equipoPokemon;

		SaveStats FirstSlot = JsonUtility.FromJson<SaveStats>(readFileOne);
		SaveStats SecondSlot = JsonUtility.FromJson<SaveStats>(readFileTwo);
		SaveStats ThirdSlot = JsonUtility.FromJson<SaveStats>(readFileThird);
		SaveStats FourthSlot = JsonUtility.FromJson<SaveStats>(readFileFourth);
		SaveStats FiveSlot = JsonUtility.FromJson<SaveStats>(readFileFive);
		SaveStats SixSlot = JsonUtility.FromJson<SaveStats>(readFileSix);

		//HP Load Stats
		if(Equipo.Count >= 1)
		{
			hpTotal[0] = FirstSlot.hpTotal;
		}

		if(Equipo.Count >= 2)
		{
			hpTotal[1] = SecondSlot.hpTotal;
		}

		if(Equipo.Count >= 3)
		{
			hpTotal[2] = ThirdSlot.hpTotal;
		}

		if(Equipo.Count >= 4)
		{
			hpTotal[3] = FourthSlot.hpTotal;
		}

		if(Equipo.Count >= 5)
		{
			hpTotal[4] = FiveSlot.hpTotal;
		}

		if(Equipo.Count >= 6)
		{
			hpTotal[5] = SixSlot.hpTotal;
		}
	}

}

[System.Serializable]
public class SaveStats {

	public string nombre;
	public int nivel;
	public int hpTotal;
	public int hpActual;
	public int ataqueTotal;
	public int ataqueEspecialTotal;
	public int defensaTotal;
	public int defensaEspecialTotal;
	public int velocidadTotal;


}