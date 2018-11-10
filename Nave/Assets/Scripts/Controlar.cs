using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controlar : MonoBehaviour {
	private int velocidade = 6;
	private Rigidbody rb;
	private Limite limite = new Limite();

	void Start () {
		rb = GetComponent<Rigidbody>();
	}

	void Update () {
		Mover ();
	}

	void Mover(){
		float movHor = Input.GetAxis("Horizontal");
		float movVer = Input.GetAxis("Vertical");
		Vector3 movimento = new Vector3(movHor, 0, movVer);
		rb.velocity = (movimento*velocidade);
		float limitarX = Mathf.Clamp (rb.position.x, limite.xMin, limite.xMax);
		float limitarZ = Mathf.Clamp (rb.position.z, limite.yMin, limite.yMax);
		rb.position = new Vector3 (limitarX, 0, limitarZ);
	}
}
