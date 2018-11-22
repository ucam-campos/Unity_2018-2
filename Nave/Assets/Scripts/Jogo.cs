using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Jogo : MonoBehaviour {
	public GameObject[] asteroides;
	public GameObject chefe;
	private bool jogadorVivo;
	private int indice;
	private AudioSource musica;
	private GameObject fimDeJogo;

	void Start () {
		fimDeJogo = GameObject.FindGameObjectWithTag("FimDeJogo");
		fimDeJogo.SetActive(false);
		musica = GetComponent<AudioSource>();
		musica.Play();
		Debug.Log(asteroides.Length);
		jogadorVivo = true;
		StartCoroutine ("Spawn");
	}

	public void FinalizarJogo(){
		Pontuacao.zera();
		jogadorVivo = false;
		Debug.Log ("Morto");
		fimDeJogo.SetActive(true);
	}

	void Update(){
		if (Input.GetKeyDown(KeyCode.R) && !jogadorVivo) {
			SceneManager.LoadScene (0);
		}
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
