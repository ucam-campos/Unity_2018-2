using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fundo : MonoBehaviour {
	Renderer rend;
	float offset = 0.3f;
	void Start(){
		rend = GetComponent<Renderer> ();
	}
    
    void Update(){
		rend.material.SetTextureOffset ("_MainTex", new Vector2(0, offset*Time.time));
    }
	
}
