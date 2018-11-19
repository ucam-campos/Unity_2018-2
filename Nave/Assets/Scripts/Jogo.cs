using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jogo : MonoBehaviour {
	public GameObject[] asteroides;
	public GameObject chefe;
	private bool jogadorVivo;
	private int indice;
	private AudioSource musica;

	public void FinalizarJogo(){
		jogadorVivo = false;
		Debug.Log ("Morto");
	}

	void Start () {
		musica = GetComponent<AudioSource>();
		musica.Play();
		Debug.Log(asteroides.Length);
		jogadorVivo = true;
		StartCoroutine ("Spawn");
	}

	IEnumerator Spawn(){
		Vector3 posicao = transform.position;
		Limite limite = new Limite ();
		while (jogadorVivo) {
			for(int i = 0; i<20; i++){
				indice = Random.Range(0,3);
				Debug.Log(indice);
				posicao.x = Random.Range (limite.xMin, limite.xMax);
				Instantiate (asteroides[indice], posicao, transform.rotation);
				yield return new WaitForSeconds(1);
			}
			posicao.x = Random.Range (limite.xMin, limite.xMax);
			Instantiate (chefe, posicao, transform.rotation);
			yield return new WaitForSeconds(10);
		}
	}



}
