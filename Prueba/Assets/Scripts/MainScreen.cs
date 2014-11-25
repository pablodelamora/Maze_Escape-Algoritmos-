using UnityEngine;
using System.Collections;

public class MainScreen : MonoBehaviour {
	//Se declaran las coordenadas para los botones
	float btnx;
	float btny;
	float btnw;
	float btnh;
	
	void Start(){
		//Se definen las posiciones de los botones de acuerdo a las dimensiones de la pantalla
		btnx = (float) (Screen.width * 0.27);
		btny = (float)  (Screen.height * 0.5);
		btnw = (float) (Screen.width * 0.2);
		btnh = (float) (Screen.height * 0.2);
	}
	
	
	
	void OnGUI(){
		//Se crean condiciones para las diferentes opciones del menu
		if (GUI.Button(new Rect(btnx,btny,btnw,btnh),"Nivel 1"))
		{
			Application.LoadLevel("Escena1");//carga escena del nivel 1.
		}
		GUI.Button(new Rect(btnx+150f,btny,btnw,btnh),"Exit");
	}
}

