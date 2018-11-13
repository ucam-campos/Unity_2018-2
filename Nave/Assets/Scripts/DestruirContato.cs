using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestruirContato : MonoBehaviour {
	public GameObject explosaoAsteroide;
	public GameObject explosaoJogador;
	private Jogo jogo;

	void Start () {
		jogo = GameObject.FindGameObjectWithTag ("GameController")
						 .GetComponent<Jogo> ();
	}

	void OnTriggerEnter(Collider outroCollider) {
		if (outroCollider.CompareTag("Limite")) {
			return;
		}
		Destroy (outroCollider.gameObject);
		Destroy (this.gameObject);
		Instantiate (explosaoAsteroide, 
					 transform.position, 
					 transform.rotation);
		if (outroCollider.CompareTag("Player")) {
			jogo.FinalizarJogo ();
			Instantiate (explosaoJogador, 
						 outroCollider.transform.position, 
						 outroCollider.transform.rotation);
		}
	}

}
