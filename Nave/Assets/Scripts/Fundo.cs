using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fundo : MonoBehaviour {

	Renderer r;
	float deslocar = 0.45f;

	void Start () {
		r=GetComponent<Renderer>();
	}
	

	void Update () {
		r.material.SetTextureOffset ("_MainTex", new Vector2 (0, deslocar * Time.time));
		
	}
}
