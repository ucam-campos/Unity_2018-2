using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Seguir : MonoBehaviour {
	public GameObject jogador;
	Vector3 distancia;

	void Start () {
		distancia = gameObject.transform.position - jogador.transform.position;
	}

	void Update () {
		gameObject.transform.position = jogador.transform.position + distancia;
	}
}
