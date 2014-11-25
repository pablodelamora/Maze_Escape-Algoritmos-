using UnityEngine;
using System.Collections;

public class BotonesGO : MonoBehaviour {
	//Se declaran coordenadas de botones
	float btnx;
	float btny;
	float btnw;
	float btnh;
	
	void Start()
	{
		//Se modifican valores de las coordenadas de los botones de acuerdo a las dimensiones de la pantalla
		btnx = (float) (Screen.width * 0.5);
		btny = (float)  (Screen.height * 0.7);
		btnw = (float) (Screen.width * 0.2);
		btnh = (float) (Screen.height * 0.2);
	}
	
	
	
	void OnGUI(){
		if (GUI.Button(new Rect(btnx,btny,btnw,btnh),"Regresar"))//Se crea boton de regresar.
		{
			//Se carga la escena donde esta el menu
			Application.LoadLevel("Escena2");
		}
	}
}