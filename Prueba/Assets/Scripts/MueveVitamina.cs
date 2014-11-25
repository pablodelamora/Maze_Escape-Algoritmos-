using UnityEngine;
using System.Collections;

public class MueveVitamina : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		transform.Rotate (new Vector3 (1f,0f, 0f));//Se aplica transformacion a las capsulas para que roten
		//en tiempo real.
	}
}
