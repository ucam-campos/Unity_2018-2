using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimento : MonoBehaviour {
	Rigidbody componente;
	private int velocidade = 5;
	private int tamanhoPulo = 5;
	bool podePular = false;

	void Start(){
		componente = GetComponent<Rigidbody>();
	}

	void OnCollisionEnter(Collision outro){
		if (outro.gameObject.name == "Chao"){
			podePular = true;
		}
	}

	void Update(){
		Mover();
		Pular();
	}

	void Mover(){
		float movHor = Input.GetAxis("Horizontal");
		float movVer = Input.GetAxis("Vertical");
		Vector3 movimento = new Vector3(movHor, 0, movVer);
		componente.AddForce(movimento*velocidade);
	}

	void Pular(){
		if(Input.GetButtonDown("Jump") && podePular){
			podePular = false;
			Vector3 pulo = new Vector3(0, tamanhoPulo, 0);
			componente.AddForce(pulo, ForceMode.Impulse);
		}
	}
}
