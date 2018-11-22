using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//[System.Serializable]


public class Controlar : MonoBehaviour {
	private Rigidbody componenteRb;
	public int velocidade = 6;
	public Limite limite;
	// Use this for initialization
	void Start () {
		componenteRb = GetComponent<Rigidbody> ();
		limite = new Limite ();
		
	}
	
	// Update is called once per frame
	void Update () {
		float x = Input.GetAxis ("Horizontal");
		float z = Input.GetAxis ("Vertical");
		Vector3 movimento = new Vector3 (x,0,z);
		componenteRb.velocity = (movimento*velocidade);
		float x_limitado = Mathf.Clamp (componenteRb.position.x,limite.xMin, limite.xMax);
		float z_limitado = Mathf.Clamp (componenteRb.position.z,limite.yMin, limite.yMax);
		componenteRb.position = new Vector3 (x_limitado, 0, z_limitado);

	}
}
