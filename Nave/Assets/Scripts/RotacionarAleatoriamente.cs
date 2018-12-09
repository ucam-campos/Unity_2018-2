using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotacionarAleatoriamente : MonoBehaviour {
	private Rigidbody componenteRb;
	private Vector3 rotacionar;
    private float aleatorio;

	void Start () {
		componenteRb = GetComponent<Rigidbody> ();
        rotacionar = Random.insideUnitSphere;
        componenteRb.AddTorque(rotacionar * (Random.Range(100, 800)));
	}
}
