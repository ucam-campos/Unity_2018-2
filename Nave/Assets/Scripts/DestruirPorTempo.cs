using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestruirPorTempo : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Destroy (this.gameObject, 2.0f);
	}
	
	// Update is called once per frame

}
