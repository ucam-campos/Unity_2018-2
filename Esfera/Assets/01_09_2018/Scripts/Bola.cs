using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Bola : MonoBehaviour {
	public int velocidade = 5;
	public Text textoPontuacao;
	private int pontos;
	private Rigidbody componenteRb;

	void Start () {
		pontos = 0;
		textoPontuacao.text = "Pontos: " + pontos;
		componenteRb = GetComponent<Rigidbody> ();
	}

	void OnTriggerEnter (Collider outro) {
		Destroy (outro.gameObject);
		pontos += 1;
		textoPontuacao.text = "Pontos: " + pontos;
	}

	void Update () {
		float x = Input.GetAxis ("Horizontal");
		float z = Input.GetAxis ("Vertical");
		// Debug.Log (x + " | " + z);
		Vector3 movimento = new Vector3 (x, 0 , z);
		componenteRb.AddForce (movimento * velocidade);
	}
}
