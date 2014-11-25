using UnityEngine;
using System.Collections;

public class Vidas : MonoBehaviour {
	public static int vidas;


	void Start () 
	{
		//Se inicializa variable vidas
		vidas = 3;
	}
	

	void Update () 
	{
		//Se actualiza el valor del texto con la variable vidas
		guiText.text = "Vidas :" + vidas;
	}
}
