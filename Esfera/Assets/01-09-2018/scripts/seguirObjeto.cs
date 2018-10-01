using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class seguirObjeto : MonoBehaviour {

	public GameObject objeto;
	private Vector3 distancia;

	void Start () {
		distancia = transform.position - objeto.transform.position;
	}
	

	void Update () {
		transform.position = objeto.transform.position + distancia;
	}
}
