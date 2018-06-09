using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventario : MonoBehaviour {

	public static Inventario instance;

	public List<Objeto> objetos = new List<Objeto>();

#region Singlenton


	void Awake()
	{
		if (instance != null)
		{
			Debug.LogWarning("Algo esta mal");
			return;
		}
		instance = this;
	}

#endregion


	public delegate void AlCambiarObjetos();
	public AlCambiarObjetos AlCambiarObjetosLlamada;
	
	public void Añadir (Objeto objeto)
	{

		if(!objeto.ObjetoBase)
		{
			objetos.Add(objeto);
			AlCambiarObjetosLlamada.Invoke();
		}
	}

	public void Eliminar (Objeto objeto)
	{
		objetos.Remove(objeto);
		AlCambiarObjetosLlamada.Invoke();
		
	}

}
