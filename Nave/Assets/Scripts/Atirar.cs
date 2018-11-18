using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Atirar : MonoBehaviour {
	public GameObject tiro;
	private float frequencia = 0.3f;
	private float proximoDisparo = 0;

	void Start () {
		
	}

	void Update () {
		if ((Input.GetButton ("Fire1") || Input.GetKey(KeyCode.Space)) && Time.time >= proximoDisparo) {
			proximoDisparo = Time.time + frequencia;
			Instantiate (tiro, transform);
		}
		
	}
}
