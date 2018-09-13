using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Item : MonoBehaviour {
	Rigidbody componente;
	public Text pontuacao;
	static int pontos = 0;
	
	void Start () {
		//pontos = 0;
		//pontuacao.text = pontos.ToString();
		componente = GetComponent<Rigidbody>();
	}
	
	private void OnTriggerEnter(Collider outro){
		if (outro.gameObject.name == "Player"){
			Debug.Log("Collected");
			pontos += 1;
			Debug.Log(pontos);
			pontuacao.text = pontos.ToString();
			Destroy(gameObject);
		}
    }
		
	void Update () {

	}

	void FixedUpdate(){
		transform.Rotate(0, 0, 2);
	}
}
