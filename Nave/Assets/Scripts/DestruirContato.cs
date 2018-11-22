using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class DestruirContato : MonoBehaviour {
	public GameObject explosao;
	public GameObject explosaonave;	
	private Jogo jogo;
	public int vida = 1;
	public Text pontuacao;
	
	void Start () {
		jogo = GameObject.FindGameObjectWithTag ("GameController")
						 .GetComponent<Jogo> ();
		pontuacao = GameObject.FindGameObjectWithTag ("pontuacao")
						 .GetComponent<Text> ();
	}

	void OnTriggerEnter(Collider outroCollider){
		if (outroCollider.CompareTag ("Limite") || outroCollider.CompareTag ("Enemy")){
			return;
		}

		vida = vida-1;
		if (vida == 0) {
			Pontuacao.AddPonto();
			pontuacao.text ="Pontos: " + Pontuacao.GetPonto();
			Destroy (outroCollider.gameObject);
			Destroy (this.gameObject);
			Instantiate (explosao, transform.position, transform.rotation);
		}else{
			Instantiate (explosao, transform.position, transform.rotation);
		}
		if (outroCollider.tag == "DestruicaoNave") {
			Destroy (outroCollider.gameObject);
			Destroy (this.gameObject);
			Instantiate (explosaonave, transform.position, transform.rotation);
			jogo.FinalizarJogo ();
		}
	}
  
}
