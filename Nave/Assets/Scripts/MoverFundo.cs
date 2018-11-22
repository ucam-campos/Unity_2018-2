using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoverFundo : MonoBehaviour {
	public float velocidade = 0.5f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		Vector2 offset = new Vector2 (0, Time.time * velocidade);
		GetComponent<Renderer>().material.mainTextureOffset = offset;
	}
}
