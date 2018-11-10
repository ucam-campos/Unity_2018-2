using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jogo : MonoBehaviour {
	public GameObject asteroide;
	public float frequencia;

	void Start () {
		StartCoroutine ("Chover");
	}
	
	IEnumerator Chover () {
		while (true) {
			Vector3 posicao = transform.position;
			Limite limite = new Limite ();
			posicao.x = Random.Range (limite.xMin, limite.xMax);
			Instantiate (asteroide, posicao, transform.rotation);
			yield return new WaitForSeconds (frequencia);
		}
	}
}
