using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Atirar : MonoBehaviour {
	public GameObject tiro;
	public float frequenciaDisparo = 0.5f;
	private float proximoDisparo;
	private AudioSource somdisparo;

	void Start () {
		somdisparo = GetComponent<AudioSource> ();
	}
	
	void Update () {
		if (Input.GetButton ("Fire1")&& Time.time >= proximoDisparo) {
			proximoDisparo = Time.time + frequenciaDisparo;
			Instantiate (tiro ,transform);
			Debug.Log ("tempo: " + Time.time + "proximo tiro: " + proximoDisparo);
			somdisparo.Play ();
		}
	}
}
