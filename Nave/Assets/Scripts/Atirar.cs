using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Atirar : MonoBehaviour {
	public GameObject tiro;
	private float frequencia = 0.3f;
	private float proximoDisparo = 0;
	
	void Update () {
		if ((Input.GetButton ("Fire1") || Input.GetKey(KeyCode.Space)) && Time.time >= proximoDisparo) {
			proximoDisparo = Time.time + frequencia;
			Instantiate (tiro, transform);
			Instantiate (tiro, new Vector3(transform.position.x + .3f, transform.position.y, transform.position.z - .3f), transform.rotation);
			Instantiate (tiro, new Vector3(transform.position.x - .3f, transform.position.y, transform.position.z - .3f), transform.rotation);
		}
	}
}
