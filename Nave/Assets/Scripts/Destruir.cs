using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destruir : MonoBehaviour {
	public GameObject explosao;

	void OnTriggerEnter(Collider outro){
		Destroy (outro.gameObject);
		Destroy (this.gameObject);
		Instantiate (explosao, transform.position, transform.rotation);
	}
}
