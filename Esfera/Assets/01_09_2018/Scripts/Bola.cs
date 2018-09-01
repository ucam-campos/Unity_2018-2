using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bola : MonoBehaviour {
	public int velocidade = 5;
	private Rigidbody componenteRb;

	void Start () {
		componenteRb = GetComponent<Rigidbody> ();
	}
	
	void Update () {
		float x = Input.GetAxis ("Horizontal");
		float z = Input.GetAxis ("Vertical");
		Debug.Log (x + " | " + z);
		Vector3 movimento = new Vector3 (x, 0 , z);
		componenteRb.AddForce (movimento * velocidade);
	}
}
