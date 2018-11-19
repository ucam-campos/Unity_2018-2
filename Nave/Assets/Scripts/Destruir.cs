using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destruir : MonoBehaviour {
	public int vida;
	public GameObject explosaoAsteroide;
	public GameObject explosaoPlayer;
	private Jogo jogo;

	void Start(){
		jogo = GameObject.FindGameObjectWithTag ("GameController")
						 .GetComponent<Jogo> ();
	}

	void OnTriggerEnter(Collider outro){
		if(!outro.CompareTag("ColliderLimite")){
			vida--;
			Instantiate (explosaoAsteroide, transform.position, transform.rotation);
			if(vida == 0){
				Destroy (this.gameObject);
			}
		
			if (outro.CompareTag ("Player")) {
				jogo.FinalizarJogo ();
				Instantiate (explosaoPlayer, outro.transform.position, outro.transform.rotation);
			}

			Destroy (outro.gameObject);	
		}
	}
}
