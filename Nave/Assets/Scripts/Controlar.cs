using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controlar : MonoBehaviour {
	private Rigidbody componente_rb;
	public int velocidade = 8;
	private Limite limite = new Limite ();


	void Start () {
		componente_rb = GetComponent<Rigidbody> ();	
	}


	void Update () {
		float x = Input.GetAxis ("Horizontal");
		float z = Input.GetAxis ("Vertical");
		Vector3 movimento = new Vector3 (x, 0, z);
		componente_rb.velocity = movimento * velocidade;
		float x_limitado = Mathf.Clamp (componente_rb.position.x, limite.xMin, limite.xMax);
		float z_limitado = Mathf.Clamp (componente_rb.position.z, limite.yMin, limite.yMax);
		componente_rb.position = new Vector3 (x_limitado, 0, z_limitado);

	}
}
