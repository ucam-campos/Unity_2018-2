using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Seguir : MonoBehaviour {
	public GameObject seguido;
	Vector3 distancia;

	void Start () {
		distancia = gameObject.transform.position - seguido.transform.position;		
	}
	
	
	void Update () {
		gameObject.transform.position = seguido.transform.position + distancia;
	}
}
