using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

[System.Serializable]
public class SaveTeamPokemon : MonoBehaviour {

	public List<PokemonData> Database = new List<PokemonData>();

	string filePathOne;
	string filePathSecond;
	string filePathThird;
	string filePathFourth;
	string filePathFive;
	string filePathSix;

	string readFileOne;
	string readFileSecond;
	string readFileThird;
	string readFileFourth;
	string readFileFive;
	string readFileSix;

	void Awake()
	{
		filePathOne = Application.dataPath + "/SaveData/TeamData/FirstSlot.json";
		readFileOne = File.ReadAllText(filePathOne);
		filePathSecond = Application.dataPath + "/SaveData/TeamData/SecondSlot.json";
		readFileSecond = File.ReadAllText(filePathSecond);
		filePathThird = Application.dataPath + "/SaveData/TeamData/ThirdSlot.json";
		readFileThird = File.ReadAllText(filePathThird);
		filePathFourth = Application.dataPath + "/SaveData/TeamData/FourthSlot.json";
		readFileFourth = File.ReadAllText(filePathFourth);
		filePathFive = Application.dataPath + "/SaveData/TeamData/FiveSlot.json";
		readFileFive = File.ReadAllText(filePathFive);
		filePathSix = Application.dataPath + "/SaveData/TeamData/SixSlot.json";
		readFileSix = File.ReadAllText(filePathSix);
	}

	public void Save()
	{
		var Equipo = EquipoPokemon.instance.equipoPokemon;

		PokemonSave FirstSlot = JsonUtility.FromJson<PokemonSave>(readFileOne);
		PokemonSave SecondSlot = JsonUtility.FromJson<PokemonSave>(readFileSecond);
		PokemonSave ThirdSlot = JsonUtility.FromJson<PokemonSave>(readFileThird);
		PokemonSave FourthSlot = JsonUtility.FromJson<PokemonSave>(readFileFourth);
		PokemonSave FiveSlot = JsonUtility.FromJson<PokemonSave>(readFileFive);
		PokemonSave SixSlot = JsonUtility.FromJson<PokemonSave>(readFileSix);

		//FirstSlot Pokemon
		if(Equipo.Count >= 1)
		{
			FirstSlot.nombre = Equipo[0].nombre;
			FirstSlot.numeroPokedex = Equipo[0].numeroPokedex - 1;

			var WriteOne = JsonUtility.ToJson(FirstSlot);
			File.WriteAllText(filePathOne, WriteOne);
		}

		else if(Equipo.Count < 1)
		{
			FirstSlot.numeroPokedex = 0;
			SecondSlot.numeroPokedex = 0;
			ThirdSlot.numeroPokedex = 0;
			FourthSlot.numeroPokedex = 0;
			FiveSlot.numeroPokedex = 0;
			SixSlot.numeroPokedex = 0;

			var WriteOne = JsonUtility.ToJson(FirstSlot);
			File.WriteAllText(filePathOne, WriteOne);
		}


		//SecondSlot Pokemon
		if(Equipo.Count >= 2)
		{
			SecondSlot.nombre = Equipo[1].nombre;
			SecondSlot.numeroPokedex = Equipo[1].numeroPokedex - 1;

			var WriteSecond = JsonUtility.ToJson(SecondSlot);
			File.WriteAllText(filePathSecond, WriteSecond);
		}

		else if(Equipo.Count < 2)
		{
			SecondSlot.numeroPokedex = 0;
			ThirdSlot.numeroPokedex = 0;
			FourthSlot.numeroPokedex = 0;
			FiveSlot.numeroPokedex = 0;
			SixSlot.numeroPokedex = 0;

			var WriteSecond = JsonUtility.ToJson(SecondSlot);
			File.WriteAllText(filePathSecond, WriteSecond);
		}

		//ThirdSlot Pokemon
		if(Equipo.Count >= 3)
		{
			ThirdSlot.nombre = Equipo[2].nombre;
			ThirdSlot.numeroPokedex = Equipo[2].numeroPokedex - 1;

			var WriteThird = JsonUtility.ToJson(ThirdSlot);
			File.WriteAllText(filePathThird, WriteThird);
		}

			else if(Equipo.Count < 3)
		{
			ThirdSlot.numeroPokedex = 0;
			FourthSlot.numeroPokedex = 0;
			FiveSlot.numeroPokedex = 0;
			SixSlot.numeroPokedex = 0;

			var WriteThird = JsonUtility.ToJson(ThirdSlot);
			File.WriteAllText(filePathThird, WriteThird);
		}
		
		//FourthSlot Pokemon
		if(Equipo.Count >= 4)
		{
			FourthSlot.nombre = Equipo[3].nombre;
			FourthSlot.numeroPokedex = Equipo[3].numeroPokedex - 1;

			var WriteFourth = JsonUtility.ToJson(FourthSlot);
			File.WriteAllText(filePathFourth, WriteFourth);
		}

			else if(Equipo.Count < 4)
		{
			FourthSlot.numeroPokedex = 0;
			FiveSlot.numeroPokedex = 0;
			SixSlot.numeroPokedex = 0;

			var WriteFourth = JsonUtility.ToJson(FourthSlot);
			File.WriteAllText(filePathFourth, WriteFourth);
		}

		//FiveSlot Pokemon
		if(Equipo.Count >= 5)
		{
			FiveSlot.nombre = Equipo[4].nombre;
			FiveSlot.numeroPokedex = Equipo[4].numeroPokedex - 1;

			var WriteFive = JsonUtility.ToJson(FiveSlot);
			File.WriteAllText(filePathFive, WriteFive);
		}

			else if(Equipo.Count < 5)
		{
			FiveSlot.numeroPokedex = 0;
			SixSlot.numeroPokedex = 0;

			var WriteFive = JsonUtility.ToJson(FiveSlot);
			File.WriteAllText(filePathFive, WriteFive);
		}
		
		//SixSlot Pokemon
		if(Equipo.Count == 6)
		{
			SixSlot.nombre = Equipo[5].nombre;
			SixSlot.numeroPokedex = Equipo[5].numeroPokedex - 1;

			var WriteSix = JsonUtility.ToJson(SixSlot);
			File.WriteAllText(filePathSix, WriteSix);
		}

			else if(Equipo.Count < 6)
		{
			SixSlot.numeroPokedex = 0;

			var WriteSix = JsonUtility.ToJson(SixSlot);
			File.WriteAllText(filePathSix, WriteSix);
		}
	}

	public void Load()
	{
		var Equipo = EquipoPokemon.instance.equipoPokemon;

		//FirsSlot Pokemon
		PokemonSave FirstSlot = JsonUtility.FromJson<PokemonSave>(readFileOne);

		if(FirstSlot.numeroPokedex > 0)
		{
			Equipo.Add(Database[FirstSlot.numeroPokedex]);
			Debug.Log(FirstSlot.nombre);
		}

		//SecondSlot Pokemon
		PokemonSave SecondSlot = JsonUtility.FromJson<PokemonSave>(readFileSecond);

		if(SecondSlot.numeroPokedex > 0)
		{
			Equipo.Add(Database[SecondSlot.numeroPokedex]);
			Debug.Log(SecondSlot.nombre);
		}

		//ThirdSlot Pokemon
		PokemonSave ThirdSlot = JsonUtility.FromJson<PokemonSave>(readFileThird);

		if(ThirdSlot.numeroPokedex > 0)
		{
			Equipo.Add(Database[ThirdSlot.numeroPokedex]);
			Debug.Log(ThirdSlot.nombre);
		}

		//FourthSlot Pokemon
		PokemonSave FourthSlot = JsonUtility.FromJson<PokemonSave>(readFileFourth);

		if(FourthSlot.numeroPokedex > 0)
		{
			Equipo.Add(Database[FourthSlot.numeroPokedex]);
			Debug.Log(FourthSlot.nombre);
		}

		//FiveSlot Pokemon
		PokemonSave FiveSlot = JsonUtility.FromJson<PokemonSave>(readFileFive);

		if(FiveSlot.numeroPokedex > 0)
		{
			Equipo.Add(Database[FiveSlot.numeroPokedex]);
			Debug.Log(FiveSlot.nombre);			
		}

		//SixSlot Pokemon
		PokemonSave SixSlot = JsonUtility.FromJson<PokemonSave>(readFileSix);

		if(SixSlot.numeroPokedex > 0)
		{
			Equipo.Add(Database[SixSlot.numeroPokedex]);
			Debug.Log(SixSlot.nombre);
		}

		//Update UI
		EquipoPokemon.instance.AlCambiarPokemonLlamada();
	}
}

[System.Serializable]
public class PokemonSave {

	public string nombre;
	public int numeroPokedex;
}
