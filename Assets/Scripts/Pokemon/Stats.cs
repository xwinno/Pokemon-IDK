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
	public int[] nivel;
	public int[] siguienteNivel;
	public float[] experienciaActual;
	public float[] experienciaSiguiente;
	public int[] hpTotal;
	public int[] hpActual;
	public int[] ataqueTotal;
	public int[] ataqueEspecialTotal;
	public int[] defensaTotal;
	public int[] defensaEspecialTotal;
	public int[] velocidadTotal;
	public Movimientos[] Mov1;
	public Movimientos[] Mov2;
	public Movimientos[] Mov3;
	public Movimientos[] Mov4;

	//Check Equipo 0 and this ID.

	void Awake()
	{
		filePathOne = Application.dataPath + "/SaveData/TeamStats/FirstSlotStats.json";
		readFileOne = File.ReadAllText(filePathOne);
		filePathTwo = Application.dataPath + "/SaveData/TeamStats/SecondSlotStats.json";
		readFileTwo = File.ReadAllText(filePathTwo);
		filePathThird = Application.dataPath + "/SaveData/TeamStats/ThirdSlotStats.json";
		readFileThird = File.ReadAllText(filePathThird);
		filePathFourth = Application.dataPath + "/SaveData/TeamStats/FourthSlotStats.json";
		readFileFourth = File.ReadAllText(filePathFourth);
		filePathFive = Application.dataPath + "/SaveData/TeamStats/FiveSlotStats.json";
		readFileFive = File.ReadAllText(filePathFive);
		filePathSix = Application.dataPath + "/SaveData/TeamStats/SixSlotStats.json";
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
			//Mov1 = pokemon.movimientos[0];
			//Mov2 = pokemon.movimientos[1];
			//Mov3 = pokemon.movimientos[2];
			//Mov4 = pokemon.movimientos[3];
	}

	void calcularHP()
	{
		var Equipo = EquipoPokemon.instance.equipoPokemon;
		
		//FirstSlot
		if(Equipo.Count >= 1)
		{
			var B1 = Equipo[0].salud;
			var L1 = Equipo[0].nivel;

			//To add IV and Nature and EV
			hpTotal[0] = ((2 * B1 + 31 + 255) * L1 / 100 + L1 + 10);
		}

		//SecondSlot

		if(Equipo.Count >= 2)
		{
			var B2 = Equipo[1].salud;
			var L2 = Equipo[1].nivel;

			hpTotal[1] = ((2 * B2 + 31 + 255) * L2 / 100 + L2 + 10);
		}
		
		//ThirdSlot
		if(Equipo.Count >= 3)
		{
			var B3 = Equipo[2].salud;
			var L3 = Equipo[2].nivel;

			hpTotal[2] = ((2 * B3 + 31 + 255) * L3 / 100 + L3 + 10);
		}
		
		//FourthSlot
		if(Equipo.Count >= 4)
		{
			var B4 = Equipo[3].salud;
			var L4 = Equipo[3].nivel;

			hpTotal[3] = ((2 * B4 + 31 + 255) * L4 / 100 + L4 + 10);
		}

		//FiveSlot
		if(Equipo.Count >= 5)
		{
			var B5 = Equipo[4].salud;
			var L5 = Equipo[4].nivel;

			hpTotal[4] = ((2 * B5 + 31 + 255) * L5 / 100 + L5 + 10);
		}

		//SixSlot
		if(Equipo.Count >= 6)
		{
			var B6 = Equipo[5].salud;
			var L6 = Equipo[5].nivel;

			hpTotal[5] = ((2 * B6 + 31 + 255) * L6 / 100 + L6 + 10);
		}
	}

	void calcularAtaque()
	{
		var Equipo = EquipoPokemon.instance.equipoPokemon;
		
		//FirstSlot
		if(Equipo.Count >= 1)
		{
			var B1 = Equipo[0].ataque;
			var L1 = Equipo[0].nivel;

			//To add IV and Nature and EV
			ataqueTotal[0] = (((2 * B1 + 31 + 255) * L1 / 100 + 5));
		}

		//SecondSlot
		if(Equipo.Count >= 2)
		{
			var B2 = Equipo[1].ataque;
			var L2 = Equipo[1].nivel;

			//To add IV and Nature and EV
			ataqueTotal[1] = (((2 * B2 + 31 + 255) * L2 / 100 + 5));
		}

		//ThirdSlot
		if(Equipo.Count >= 3)
		{
			var B3 = Equipo[2].ataque;
			var L3 = Equipo[2].nivel;

			//To add IV and Nature and EV
			ataqueTotal[2] = (((2 * B3 + 31 + 255) * L3 / 100 + 5));
		}

		//FourthSlot
		if(Equipo.Count >= 4)
		{
			var B4 = Equipo[3].ataque;
			var L4 = Equipo[3].nivel;

			//To add IV and Nature and EV
			ataqueTotal[3] = (((2 * B4 + 31 + 255) * L4 / 100 + 5));
		}

		//FiveSlot
		if(Equipo.Count >= 5)
		{
			var B5 = Equipo[4].ataque;
			var L5 = Equipo[4].nivel;

			//To add IV and Nature and EV
			ataqueTotal[4] = (((2 * B5 + 31 + 255) * L5 / 100 + 5));
		}

		//SixSlot
		if(Equipo.Count >= 6)
		{
			var B6 = Equipo[5].ataque;
			var L6 = Equipo[5].nivel;

			//To add IV and Nature and EV
			ataqueTotal[5] = (((2 * B6 + 31 + 255) * L6 / 100 + 5));
		}
	}

	void calcularAtaqueEspecial()
	{
		var Equipo = EquipoPokemon.instance.equipoPokemon;
		
		//FirstSlot
		if(Equipo.Count >= 1)
		{
			var B1 = Equipo[0].ataqueEspecial;
			var L1 = Equipo[0].nivel;

			//To add IV and Nature and EV
			ataqueEspecialTotal[0] = (((2 * B1 + 31 + 255) * L1 / 100 + 5));
		}

		//SecondSlot
		if(Equipo.Count >= 2)
		{
			var B2 = Equipo[1].ataqueEspecial;
			var L2 = Equipo[1].nivel;

			//To add IV and Nature and EV
			ataqueEspecialTotal[1] = (((2 * B2 + 31 + 255) * L2 / 100 + 5));
		}

		//ThirdSlot
		if(Equipo.Count >= 3)
		{
			var B3 = Equipo[2].ataqueEspecial;
			var L3 = Equipo[2].nivel;

			//To add IV and Nature and EV
			ataqueEspecialTotal[2] = (((2 * B3 + 31 + 255) * L3 / 100 + 5));
		}

		//FourthSlot
		if(Equipo.Count >= 4)
		{
			var B4 = Equipo[3].ataqueEspecial;
			var L4 = Equipo[3].nivel;

			//To add IV and Nature and EV
			ataqueEspecialTotal[3] = (((2 * B4 + 31 + 255) * L4 / 100 + 5));
		}

		//FiveSlot
		if(Equipo.Count >= 5)
		{
			var B5 = Equipo[4].ataqueEspecial;
			var L5 = Equipo[4].nivel;

			//To add IV and Nature and EV
			ataqueEspecialTotal[4] = (((2 * B5 + 31 + 255) * L5 / 100 + 5));
		}

		//SixSlot
		if(Equipo.Count >= 6)
		{
			var B6 = Equipo[5].ataqueEspecial;
			var L6 = Equipo[5].nivel;

			//To add IV and Nature and EV
			ataqueEspecialTotal[5] = (((2 * B6 + 31 + 255) * L6 / 100 + 5));
		}
	}

	void calcularDefensa()
	{
		var Equipo = EquipoPokemon.instance.equipoPokemon;
		
		//FirstSlot
		if(Equipo.Count >= 1)
		{
			var B1 = Equipo[0].defensa;
			var L1 = Equipo[0].nivel;

			//To add IV and Nature and EV
			defensaTotal[0] = (((2 * B1 + 31 + 255) * L1 / 100 + 5));
		}

		//SecondSlot
		if(Equipo.Count >= 2)
		{
			var B2 = Equipo[1].defensa;
			var L2 = Equipo[1].nivel;

			//To add IV and Nature and EV
			defensaTotal[1] = (((2 * B2 + 31 + 255) * L2 / 100 + 5));
		}

		//ThirdSlot
		if(Equipo.Count >= 3)
		{
			var B3 = Equipo[2].defensa;
			var L3 = Equipo[2].nivel;

			//To add IV and Nature and EV
			defensaTotal[2] = (((2 * B3 + 31 + 255) * L3 / 100 + 5));
		}

		//FourthSlot
		if(Equipo.Count >= 4)
		{
			var B4 = Equipo[3].defensa;
			var L4 = Equipo[3].nivel;

			//To add IV and Nature and EV
			defensaTotal[3] = (((2 * B4 + 31 + 255) * L4 / 100 + 5));
		}

		//FiveSlot
		if(Equipo.Count >= 5)
		{
			var B5 = Equipo[4].defensa;
			var L5 = Equipo[4].nivel;

			//To add IV and Nature and EV
			defensaTotal[4] = (((2 * B5 + 31 + 255) * L5 / 100 + 5));
		}

		//SixSlot
		if(Equipo.Count >= 6)
		{
			var B6 = Equipo[5].defensa;
			var L6 = Equipo[5].nivel;

			//To add IV and Nature and EV
			defensaTotal[5] = (((2 * B6 + 31 + 255) * L6 / 100 + 5));
		}
	}

	void calcularDefensaEspecial()
	{
		var Equipo = EquipoPokemon.instance.equipoPokemon;
		
		//FirstSlot
		if(Equipo.Count >= 1)
		{
			var B1 = Equipo[0].defensaEspecial;
			var L1 = Equipo[0].nivel;

			//To add IV and Nature and EV
			defensaEspecialTotal[0] = (((2 * B1 + 31 + 255) * L1 / 100 + 5));
		}

		//SecondSlot
		if(Equipo.Count >= 2)
		{
			var B2 = Equipo[1].defensaEspecial;
			var L2 = Equipo[1].nivel;

			//To add IV and Nature and EV
			defensaEspecialTotal[1] = (((2 * B2 + 31 + 255) * L2 / 100 + 5));
		}

		//ThirdSlot
		if(Equipo.Count >= 3)
		{
			var B3 = Equipo[2].defensaEspecial;
			var L3 = Equipo[2].nivel;

			//To add IV and Nature and EV
			defensaEspecialTotal[2] = (((2 * B3 + 31 + 255) * L3 / 100 + 5));
		}

		//FourthSlot
		if(Equipo.Count >= 4)
		{
			var B4 = Equipo[3].defensaEspecial;
			var L4 = Equipo[3].nivel;

			//To add IV and Nature and EV
			defensaEspecialTotal[3] = (((2 * B4 + 31 + 255) * L4 / 100 + 5));
		}

		//Slot
		if(Equipo.Count >= 5)
		{
			var B5 = Equipo[4].defensaEspecial;
			var L5 = Equipo[4].nivel;

			//To add IV and Nature and EV
			defensaEspecialTotal[4] = (((2 * B5 + 31 + 255) * L5 / 100 + 5));
		}

		//SixSlot
		if(Equipo.Count >= 6)
		{
			var B6 = Equipo[5].defensaEspecial;
			var L6 = Equipo[5].nivel;

			//To add IV and Nature and EV
			defensaEspecialTotal[5] = (((2 * B6 + 31 + 255) * L6 / 100 + 5));
		}
	}

	void calcularVelocidad()
	{
		var Equipo = EquipoPokemon.instance.equipoPokemon;
		
		//FirstSlot
		if(Equipo.Count >= 1)
		{
			var B1 = Equipo[0].velocidad;
			var L1 = Equipo[0].nivel;

			//To add IV and Nature and EV
			velocidadTotal[0] = (((2 * B1 + 31 + 255) * L1 / 100 + 5));
		}

		//SecondSlot
		if(Equipo.Count >= 2)
		{
			var B2 = Equipo[1].velocidad;
			var L2 = Equipo[1].nivel;

			//To add IV and Nature and EV
			velocidadTotal[1] = (((2 * B2 + 31 + 255) * L2 / 100 + 5));
		}

		//ThirdSlot
		if(Equipo.Count >= 3)
		{
			var B3 = Equipo[2].velocidad;
			var L3 = Equipo[2].nivel;

			//To add IV and Nature and EV
			velocidadTotal[2] = (((2 * B3 + 31 + 255) * L3 / 100 + 5));
		}

		//FourthSlot
		if(Equipo.Count >= 4)
		{
			var B4 = Equipo[3].velocidad;
			var L4 = Equipo[3].nivel;

			//To add IV and Nature and EV
			velocidadTotal[3] = (((2 * B4 + 31 + 255) * L4 / 100 + 5));
		}

		//FiveSlot
		if(Equipo.Count >= 5)
		{
			var B5 = Equipo[4].velocidad;
			var L5 = Equipo[4].nivel;

			//To add IV and Nature and EV
			velocidadTotal[4] = (((2 * B5 + 31 + 255) * L5 / 100 + 5));
		}

		//SixSlot
		if(Equipo.Count >= 6)
		{
			var B6 = Equipo[5].velocidad;
			var L6 = Equipo[5].nivel;

			//To add IV and Nature and EV
			velocidadTotal[5] = (((2 * B6 + 31 + 255) * L6 / 100 + 5));
		}
	}


	void calcularSiguienteNivel()
	{
		var Equipo = EquipoPokemon.instance.equipoPokemon;
		
		//FirstSlot
		if(Equipo.Count >= 1)
		{
			nivel[0] = Equipo[0].nivel;
			siguienteNivel[0] = nivel[0] + 1;
			experienciaSiguiente[0] = (6 * (Mathf.Pow(siguienteNivel[0],3)) / 5  - 15 * (Mathf.Pow(siguienteNivel[0], 2)) + 100 * (siguienteNivel[0]) - 140);
		}

		if(Equipo.Count >= 2)
		{
			nivel[1] = Equipo[1].nivel;
			siguienteNivel[1] = nivel[1] + 1;
			experienciaSiguiente[1] = (6 * (Mathf.Pow(siguienteNivel[1],3)) / 5  - 15 * (Mathf.Pow(siguienteNivel[1], 2)) + 100 * (siguienteNivel[1]) - 140);
		}
		
		if(Equipo.Count >= 3)
		{
			nivel[2] = Equipo[2].nivel;
			siguienteNivel[2] = nivel[2] + 1;
			experienciaSiguiente[2] = (6 * (Mathf.Pow(siguienteNivel[2],3)) / 5  - 15 * (Mathf.Pow(siguienteNivel[2], 2)) + 100 * (siguienteNivel[2]) - 140);
		}

		if(Equipo.Count >= 4)
		{
			nivel[3] = Equipo[3].nivel;
			siguienteNivel[3] = nivel[3] + 1;
			experienciaSiguiente[3] = (6 * (Mathf.Pow(siguienteNivel[3],3)) / 5  - 15 * (Mathf.Pow(siguienteNivel[3], 2)) + 100 * (siguienteNivel[3]) - 140);
		}

		if(Equipo.Count >= 5)
		{
			nivel[4] = Equipo[4].nivel;
			siguienteNivel[4] = nivel[4] + 1;
			experienciaSiguiente[4] = (6 * (Mathf.Pow(siguienteNivel[4],3)) / 5  - 15 * (Mathf.Pow(siguienteNivel[4], 2)) + 100 * (siguienteNivel[4]) - 140);
		}

		if(Equipo.Count >= 6)
		{
			nivel[5] = Equipo[5].nivel;
			siguienteNivel[5] = nivel[5] + 1;
			experienciaSiguiente[5] = (6 * (Mathf.Pow(siguienteNivel[5],3)) / 5  - 15 * (Mathf.Pow(siguienteNivel[5], 2)) + 100 * (siguienteNivel[5]) - 140);
		}
	}


	public void Recovery()
	{
		var Equipo = EquipoPokemon.instance.equipoPokemon;

		if(Equipo.Count >= 1)
		{
			hpActual[0] = hpTotal[0];
		}

		if(Equipo.Count >= 2)
		{
			hpActual[1] = hpTotal[1];
		}

		if(Equipo.Count >= 3)
		{
			hpActual[2] = hpTotal[2];
		}

		if(Equipo.Count >= 4)
		{
			hpActual[3] = hpTotal[3];
		}

		if(Equipo.Count >= 5)
		{
			hpActual[4] = hpTotal[4];
		}

		if(Equipo.Count >= 6)
		{
			hpActual[5] = hpTotal[5];
		}
	}

	public void SaveStats()
	{
		var Equipo = EquipoPokemon.instance.equipoPokemon;
		SaveStats FirstSlot = JsonUtility.FromJson<SaveStats>(readFileOne);
		SaveStats SecondSlot = JsonUtility.FromJson<SaveStats>(readFileTwo);
		SaveStats ThirdSlot = JsonUtility.FromJson<SaveStats>(readFileThird);
		SaveStats FourthSlot = JsonUtility.FromJson<SaveStats>(readFileFourth);
		SaveStats FiveSlot = JsonUtility.FromJson<SaveStats>(readFileFive);
		SaveStats SixSlot = JsonUtility.FromJson<SaveStats>(readFileSix);

		//Stats
		calcularHP();
		calcularAtaque();
		calcularAtaqueEspecial();
		calcularDefensa();
		calcularDefensaEspecial();
		calcularVelocidad();
		calcularSiguienteNivel();

		//FirstSlot
		if(Equipo.Count >= 1)
		{
			FirstSlot.hpTotal = hpTotal[0];
			FirstSlot.ataqueTotal = ataqueTotal[0];
			FirstSlot.ataqueEspecialTotal = ataqueEspecialTotal[0];
			FirstSlot.defensaTotal = defensaTotal[0];
			FirstSlot.defensaEspecialTotal = defensaEspecialTotal[0];
			FirstSlot.velocidadTotal = velocidadTotal[0];
			FirstSlot.experienciaSiguiente = experienciaSiguiente[0];
			FirstSlot.nivel = nivel[0];
			FirstSlot.siguienteNivel = siguienteNivel[0];

			var WriteOne = JsonUtility.ToJson(FirstSlot);
			File.WriteAllText(filePathOne, WriteOne);
		}

		//SecondSlot
		if(Equipo.Count >= 2)
		{
			SecondSlot.hpTotal = hpTotal[1];
			SecondSlot.ataqueTotal = ataqueTotal[1];
			SecondSlot.ataqueEspecialTotal = ataqueEspecialTotal[1];
			SecondSlot.defensaTotal = defensaTotal[1];
			SecondSlot.defensaEspecialTotal = defensaEspecialTotal[1];
			SecondSlot.velocidadTotal = velocidadTotal[1];
			SecondSlot.experienciaSiguiente = experienciaSiguiente[1];
			SecondSlot.nivel = nivel[1];
			SecondSlot.siguienteNivel = siguienteNivel[1];

			var WriteTwo = JsonUtility.ToJson(SecondSlot);
			File.WriteAllText(filePathTwo, WriteTwo);
		}

		//ThirdSlot
		if(Equipo.Count >= 3)
		{
			ThirdSlot.hpTotal = hpTotal[2];
			ThirdSlot.ataqueTotal = ataqueTotal[2];
			ThirdSlot.ataqueEspecialTotal = ataqueEspecialTotal[2];
			ThirdSlot.defensaTotal = defensaTotal[2];
			ThirdSlot.defensaEspecialTotal = defensaEspecialTotal[2];
			ThirdSlot.velocidadTotal = velocidadTotal[2];
			ThirdSlot.experienciaSiguiente = experienciaSiguiente[2];
			ThirdSlot.nivel = nivel[2];
			ThirdSlot.siguienteNivel = siguienteNivel[2];

			var WriteThird = JsonUtility.ToJson(ThirdSlot);
			File.WriteAllText(filePathThird, WriteThird);
		}

		//FourthSlot
		if(Equipo.Count >= 4)
		{
			FourthSlot.hpTotal = hpTotal[3];
			FourthSlot.ataqueTotal = ataqueTotal[3];
			FourthSlot.ataqueEspecialTotal = ataqueEspecialTotal[3];
			FourthSlot.defensaTotal = defensaTotal[3];
			FourthSlot.defensaEspecialTotal = defensaEspecialTotal[3];
			FourthSlot.velocidadTotal = velocidadTotal[3];
			FourthSlot.experienciaSiguiente = experienciaSiguiente[3];
			FourthSlot.nivel = nivel[3];
			FourthSlot.siguienteNivel = siguienteNivel[3];

			var WriteFourth = JsonUtility.ToJson(FourthSlot);
			File.WriteAllText(filePathFourth, WriteFourth);
		}

		//FiveSlot
		if(Equipo.Count >= 5)
		{
			FiveSlot.hpTotal = hpTotal[4];
			FiveSlot.ataqueTotal = ataqueTotal[4];
			FiveSlot.ataqueEspecialTotal = ataqueEspecialTotal[4];
			FiveSlot.defensaTotal = defensaTotal[4];
			FiveSlot.defensaEspecialTotal = defensaEspecialTotal[4];
			FiveSlot.velocidadTotal = velocidadTotal[4];
			FiveSlot.experienciaSiguiente = experienciaSiguiente[4];
			FiveSlot.nivel = nivel[4];
			FiveSlot.siguienteNivel = siguienteNivel[4];

			var WriteFive = JsonUtility.ToJson(FiveSlot);
			File.WriteAllText(filePathFive, WriteFive);
		}

		//SixSlot
		if(Equipo.Count >= 6)
		{
			SixSlot.hpTotal = hpTotal[5];
			SixSlot.ataqueTotal = ataqueTotal[5];
			SixSlot.ataqueEspecialTotal = ataqueEspecialTotal[5];
			SixSlot.defensaTotal = defensaTotal[5];
			SixSlot.defensaEspecialTotal = defensaEspecialTotal[5];
			SixSlot.velocidadTotal = velocidadTotal[5];
			SixSlot.experienciaSiguiente = experienciaSiguiente[5];
			SixSlot.nivel = nivel[5];
			SixSlot.siguienteNivel = siguienteNivel[5];

			var WriteSix = JsonUtility.ToJson(SixSlot);
			File.WriteAllText(filePathSix, WriteSix);
		}
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
			ataqueTotal[0] = FirstSlot.ataqueTotal;
			ataqueEspecialTotal[0] = FirstSlot.ataqueEspecialTotal;
			defensaTotal[0] = FirstSlot.defensaTotal;
			defensaEspecialTotal[0] = FirstSlot.defensaEspecialTotal;
			velocidadTotal[0] = FirstSlot.velocidadTotal;
			nivel[0] = FirstSlot.nivel;
		}

		if(Equipo.Count >= 2)
		{
			hpTotal[1] = SecondSlot.hpTotal;
			ataqueTotal[1] = SecondSlot.ataqueTotal;
			ataqueEspecialTotal[1] = SecondSlot.ataqueEspecialTotal;
			defensaTotal[1] = SecondSlot.defensaTotal;
			defensaEspecialTotal[1] = SecondSlot.defensaEspecialTotal;
			velocidadTotal[1] = SecondSlot.velocidadTotal;
			nivel[1] = SecondSlot.nivel;
		}

		if(Equipo.Count >= 3)
		{
			hpTotal[2] = ThirdSlot.hpTotal;
			ataqueTotal[2] = ThirdSlot.ataqueTotal;
			ataqueEspecialTotal[2] = ThirdSlot.ataqueEspecialTotal;
			defensaTotal[2] = ThirdSlot.defensaTotal;
			defensaEspecialTotal[2] = ThirdSlot.defensaEspecialTotal;
			velocidadTotal[2] = ThirdSlot.velocidadTotal;
			nivel[2] = ThirdSlot.nivel;
		}

		if(Equipo.Count >= 4)
		{
			hpTotal[3] = FourthSlot.hpTotal;
			ataqueTotal[3] = FourthSlot.ataqueTotal;
			ataqueEspecialTotal[3] = FourthSlot.ataqueEspecialTotal;
			defensaTotal[3] = FourthSlot.defensaTotal;
			defensaEspecialTotal[3] = FourthSlot.defensaEspecialTotal;
			velocidadTotal[3] = FourthSlot.velocidadTotal;
			nivel[3] = FourthSlot.nivel;
		}

		if(Equipo.Count >= 5)
		{
			hpTotal[4] = FiveSlot.hpTotal;
			ataqueTotal[4] = FiveSlot.ataqueTotal;
			ataqueEspecialTotal[4] = FiveSlot.ataqueEspecialTotal;
			defensaTotal[4] = FiveSlot.defensaTotal;
			defensaEspecialTotal[4] = FiveSlot.defensaEspecialTotal;
			velocidadTotal[4] = FiveSlot.velocidadTotal;
			nivel[4] = FiveSlot.nivel;
		}

		if(Equipo.Count >= 6)
		{
			hpTotal[5] = SixSlot.hpTotal;
			ataqueTotal[5] = SixSlot.ataqueTotal;
			ataqueEspecialTotal[5] = SixSlot.ataqueEspecialTotal;
			defensaTotal[5] = SixSlot.defensaTotal;
			defensaEspecialTotal[5] = SixSlot.defensaEspecialTotal;
			velocidadTotal[5] = SixSlot.velocidadTotal;
			nivel[5] = SixSlot.nivel;
		}
	}
}

[System.Serializable]
public class SaveStats {

	public string nombre;
	public int nivel;
	public int siguienteNivel;
	public float experienciaActual;
	public float experienciaSiguiente;
	public int hpTotal;
	public int hpActual;
	public int ataqueTotal;
	public int ataqueEspecialTotal;
	public int defensaTotal;
	public int defensaEspecialTotal;
	public int velocidadTotal;

}