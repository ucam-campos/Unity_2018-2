using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestruirPorTempo : MonoBehaviour {
	void Start () {
		Destroy (this.gameObject, 2.0f);
	}
}
