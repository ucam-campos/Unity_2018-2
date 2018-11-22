using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Jogo : MonoBehaviour {
	public GameObject boss;
	private float frequencia = 0.5f;
	public GameObject[] asteroides;
	public GameObject textoFimJogo;
	private bool jogadorVivo;
	private int totalAsteroides = 20;

	void Update () {
		if (Input.GetKeyDown(KeyCode.R) && !jogadorVivo) {
			SceneManager.LoadScene (0);
		}
	}

	public void FinalizarJogo () {
		jogadorVivo = false;
		textoFimJogo.SetActive (true);
		Pontuacao.ZerarPonto();
	}

	void Start () {
		jogadorVivo = true;
		textoFimJogo.SetActive (false);
		StartCoroutine ("Aparecer");
	}

	IEnumerator espere(float tempo){
    	yield return new WaitForSeconds(tempo);
	}
	
	IEnumerator Aparecer(){
		while (true){
			
			for (int i=0;i<totalAsteroides;i++){
				int indice = Random.Range (0, 4);
				Vector3 posicao = transform.position;
				Limite limite = new Limite ();
				posicao.x = Random.Range (limite.xMin, limite.xMax);
				Instantiate (asteroides[indice], posicao, transform.rotation);
				yield return espere (frequencia);
			}	
			yield return espere(5);
			Vector3 posicao2 = transform.position;
			Limite limite2 = new Limite ();
			posicao2.x = Random.Range (limite2.xMin, limite2.xMax);
			Instantiate (boss, posicao2, transform.rotation);
			yield return espere(8);
		}
	}
}

