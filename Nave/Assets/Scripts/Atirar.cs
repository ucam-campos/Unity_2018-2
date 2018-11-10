using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Atirar : MonoBehaviour {
	public GameObject tiro;
	public float frequenciaDisparo = 0.5f;
	private float proximoDisparo = 0;
	private AudioSource somDisparo;

	void Start () {
		somDisparo = GetComponent<AudioSource> ();
	}

	void Update () {
		if (Input.GetButton("Fire1") && Time.time >= proximoDisparo) {
			proximoDisparo = Time.time + frequenciaDisparo;
			Instantiate (tiro, transform);
			somDisparo.Play ();
		}
	}
}
