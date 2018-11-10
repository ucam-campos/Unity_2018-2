using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jogo : MonoBehaviour {
	public GameObject asteroide;
	private bool jogadorVivo;

	public void FinalizarJogo(){
		jogadorVivo = false;
		Debug.Log ("Morto");
	}

	void Start () {
		jogadorVivo = true;
		StartCoroutine ("Spawn");
	}

	IEnumerator Spawn(){
		while (jogadorVivo) {
			Vector3 posicao = transform.position;
			Limite limite = new Limite ();
			posicao.x = Random.Range (limite.xMin, limite.xMax);
			Instantiate (asteroide, posicao, transform.rotation);
			yield return new WaitForSeconds(1);
		}
	}

}
