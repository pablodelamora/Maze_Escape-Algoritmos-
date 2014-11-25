using UnityEngine;
using System.Collections;

public class Puntos : MonoBehaviour {
	public static int puntos;//Se declara variable publica


	void Start () 
	{
		puntos = 0;//Se inicializa variable
	}
	

	void Update () 
	{
		guiText.text = "Puntos :" + puntos;//Se cambia texto de la etiqueta.
	}
}
