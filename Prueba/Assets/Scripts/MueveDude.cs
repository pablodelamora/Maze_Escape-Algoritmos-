using UnityEngine;
using System.Collections;

public class MueveDude : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey(KeyCode.DownArrow))
						transform.Translate (new Vector3 (0.0f, 0.0f, 0.5f));//Se mueve el persona
	}
}
