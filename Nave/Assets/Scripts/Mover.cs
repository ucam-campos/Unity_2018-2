using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour {
	Rigidbody rb;
	public float velocidade = 10;

	void Start () {
		rb = GetComponent<Rigidbody>();
	}

	void Update () {
		rb.velocity = Vector3.forward * velocidade;
	}
}
