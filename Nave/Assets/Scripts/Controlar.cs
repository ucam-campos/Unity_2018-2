using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Limite {
	public float xMax; 
	public float xMin; 
	public float yMax; 
	public float yMin; 
}

public class Controlar : MonoBehaviour {
	private Rigidbody componente_rb;
	public Limite limite;
	public int velocidade = 10;


	void Start () {
		componente_rb = GetComponent<Rigidbody> ();	
	}


	void Update () {
		float x = Input.GetAxis ("Horizontal");
		float y = Input.GetAxis ("Vertical");
		Vector3 movimento = new Vector3 (x, 0, y);
		componente_rb.velocity = movimento * velocidade;
		float x_limitado = Mathf.Clamp (componente_rb.position.x, -6.0f, 6.0f);
		float z_limitado = Mathf.Clamp (componente_rb.position.z, -4.0f, 10.0f);
		componente_rb.position = new Vector3 (x_limitado, 0, z_limitado);
	}
}
