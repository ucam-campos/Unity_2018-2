using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotacionar : MonoBehaviour {
	private Rigidbody rb;
	private Vector3 rotacao;

	void Start () {
		rb = GetComponent<Rigidbody>();
		Vector3 rotacao = Random.insideUnitSphere;
		rb.AddTorque (rotacao * 500);
	}	

	void Update () {
		
	}
}
