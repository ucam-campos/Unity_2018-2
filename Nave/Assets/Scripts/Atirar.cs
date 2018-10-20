using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Atirar : MonoBehaviour {
	private Rigidbody componenteRb;
	public int velocidade;

	void Start () {
		componenteRb = GetComponent<Rigidbody> ();
	}
	
	void Update () {
		
		componenteRb.velocity = Vector3.forward * velocidade;
	}
}
