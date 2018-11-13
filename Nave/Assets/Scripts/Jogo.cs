using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Jogo : MonoBehaviour {
	public GameObject asteroide;
	public float frequencia = 0.5f;
	public GameObject textoFimJogo;
	private Limite limite = new Limite ();
	private bool jogadorVivo;

	void Update () {
		if (Input.GetKeyDown(KeyCode.R) && !jogadorVivo) {
			SceneManager.LoadScene (0);
		}
	}

	public void FinalizarJogo () {
		jogadorVivo = false;
		textoFimJogo.SetActive (true);
	}

	void Start () {
		jogadorVivo = true;
		StartCoroutine ("Chover");
	}
	
	IEnumerator Chover () {
		while (true) {
			Vector3 posicao = transform.position;
			posicao.x = Random.Range (limite.xMin, limite.xMax);
			Instantiate (asteroide, posicao, transform.rotation);
			yield return new WaitForSeconds (frequencia);
		}
	}
}
