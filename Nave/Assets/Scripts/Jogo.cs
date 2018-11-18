using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jogo : MonoBehaviour {
	public GameObject[] asteroides;
	private bool jogadorVivo;
	private int indice;

	public void FinalizarJogo(){
		jogadorVivo = false;
		Debug.Log ("Morto");
	}

	void Start () {
		Debug.Log(asteroides.Length);
		jogadorVivo = true;
		StartCoroutine ("Spawn");
	}

	IEnumerator Spawn(){
		while (jogadorVivo) {
			indice = Random.Range(0,3);
			Debug.Log(indice);
			Vector3 posicao = transform.position;
			Limite limite = new Limite ();
			posicao.x = Random.Range (limite.xMin, limite.xMax);
			Instantiate (asteroides[indice], posicao, transform.rotation);
			yield return new WaitForSeconds(1);
		}
	}

}
