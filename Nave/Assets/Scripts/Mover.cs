using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour {
	private Rigidbody componeteRB;
	public int velocidade;
	// Use this for initialization
	void Start () {
		componeteRB = GetComponent <Rigidbody> ();
	}
	
	// Update is called once per frame
	void Update () {
		componeteRB.velocity = Vector3.forward * velocidade;
		
	}
}
