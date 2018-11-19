using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotacionar : MonoBehaviour {
	private Rigidbody rb;
	private Vector3 rotacao;
	public float multiplicador;

	void Start () {
		rb = GetComponent<Rigidbody>();
		Vector3 rotacao = Random.insideUnitSphere;
		rb.AddTorque (rotacao * multiplicador);
	}	

	void Update () {
		
	}
}
