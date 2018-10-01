using System.Collections;
using System.Collections.Generic;
using UnityEngine;

<<<<<<< HEAD
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
=======
public class Controlar : MonoBehaviour {
	private int velocidade = 6;
	private Rigidbody rb;
	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
		Mover ();
	}

	void Mover(){
		float movHor = Input.GetAxis("Horizontal");
		float movVer = Input.GetAxis("Vertical");
		Vector3 movimento = new Vector3(movHor, 0, movVer);
		rb.velocity = (movimento*velocidade);
		float limitarX = Mathf.Clamp (rb.position.x, -6.0f, 6.0f);
		float limitarZ = Mathf.Clamp (rb.position.z, -1.0f, 17.0f);
		rb.position = new Vector3 (limitarX, 0, limitarZ);
>>>>>>> d0e82a38e3b9d417495c6a6039bd7007653c20bd
	}
}
