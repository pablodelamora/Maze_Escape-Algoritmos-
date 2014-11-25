using UnityEngine;
using System.Collections;

public class Maduracion : MonoBehaviour {
	public static int madurar;//Se declara variable publica


	void Start()
	{
		madurar = 0;//Se inicializa variable
	}
	void Update () 
	{
		guiText.text = "Maduracion :" + madurar+" %";//Se cambia texto de la etiqueta.
	}
}
