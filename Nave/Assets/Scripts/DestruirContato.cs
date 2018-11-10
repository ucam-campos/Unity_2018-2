using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestruirContato : MonoBehaviour {
	public GameObject explosaoAsteroide;
	public GameObject explosaoJogador;

	void OnTriggerEnter(Collider outroCollider) {
		Destroy (outroCollider.gameObject);
		Destroy (this.gameObject);
		Instantiate (explosaoAsteroide, 
					 transform.position, 
					 transform.rotation);
		if (outroCollider.CompareTag("Player")) {
			Instantiate (explosaoJogador, 
						 outroCollider.transform.position, 
						 outroCollider.transform.rotation);
		}
	}

}
