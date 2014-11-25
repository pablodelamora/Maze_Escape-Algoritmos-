using UnityEngine;
using System.Collections;

public class MaduraFinal : MonoBehaviour {

	// Cambia el valor de la etiqueta en pantalla GO
	void Start () {
		guiText.text = "Maduracion: " + Maduracion.madurar;
	}
	

}
