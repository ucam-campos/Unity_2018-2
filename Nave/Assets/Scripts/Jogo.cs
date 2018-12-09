using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Jogo : MonoBehaviour {
	private AudioSource music;
	private bool jogadorVivo;
	private GameObject textoFimJogo;
	public GameObject[] asteroides;
	public GameObject chefao;
	private int indice;

	void Start () {
		textoFimJogo = GameObject.FindGameObjectWithTag("Fim");
		textoFimJogo.SetActive(false);
		music = GetComponent<AudioSource>();
		music.Play();
		jogadorVivo = true;
		StartCoroutine ("Chover");
	}

	void Update () {
		if (Input.GetKeyDown(KeyCode.R) && !jogadorVivo) {
			SceneManager.LoadScene (0);
		}
	}

	public void FinalizarJogo () {
		jogadorVivo = false;
		textoFimJogo.SetActive (true);
		Pontuacao.recomecar ();
	}


	
	IEnumerator Chover () {
		Limite limite = new Limite ();
		Vector3 posicao = transform.position;
		while (jogadorVivo) {
			for (int i = 0; i < 20; i++) {
				indice = Random.Range (0, 3);
				posicao.x = Random.Range (limite.xMin, limite.xMax);
				Instantiate (asteroides[indice], posicao, transform.rotation);
				yield return new WaitForSeconds (1.2f);

			}
			posicao.x = Random.Range (limite.xMin, limite.xMax);
			Instantiate (chefao, posicao, transform.rotation);
			yield return new WaitForSeconds (10);
		}
				
	}
}

