using UnityEngine;
using System.Collections;

public class ControlPers : MonoBehaviour {


	void OnCollisionEnter(Collision col)//Metodo para detectar colision.
	{
		//Se hacen las condiciones para las diferentes vitaminas
		if (col.gameObject.name == "VitaminaVerde") {
			//Si es una vitamina verde se suman dos puntos y dos por ciento de maduracion
			Maduracion.madurar += 2;
			Puntos.puntos += 2;
			Destroy(col.gameObject);//Se elimina el objeto colisionado
			audio.Play();//Se reproduce sonido
			}
		if (col.gameObject.name == "VitaminaAmarilla") {
			//Si es una vitamina amarilla se suman 5 puntos y 5 por ciento de maduracion
			Maduracion.madurar +=5;
			Puntos.puntos += 5;
			Destroy(col.gameObject);//Se elimina el objeto colisionado
			audio.Play ();//Se reproduce sonido
				}
		if (col.gameObject.name == "VitaminaNaranja") {
			//Si es una vitamina naranja se suman 10 puntos y 10 por ciento de maduracion
			Maduracion.madurar +=10;
			Puntos.puntos += 10;
			Destroy(col.gameObject);//Se elimina el objeto colisionado
			audio.Play ();//Se reproduce sonido
				}
		if (col.gameObject.name == "VitaminaMorada") {
			//Si es una vitamina morada se suman 25 puntos y 25 por ciento de maduracion
			Maduracion.madurar +=25;
			Puntos.puntos +=25;
			Destroy(col.gameObject);//Se elimina el objeto colisionado
			audio.Play ();//Se reproduce sonido
			}
		if (col.gameObject.name == "Kid") {
			//Si el objeto es un niño, se resta una vida y despues de 3 se manda pantalla GO.
			if(Vidas.vidas!=0)
			Vidas.vidas--;
			else
			{
			Application.LoadLevel("GameOver");
			}
		}
		if (col.gameObject.name == "Exit") {
			Application.LoadLevel("GameOver");
			Destroy(col.gameObject);
		}
	}

}