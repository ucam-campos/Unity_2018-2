using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestruirSair : MonoBehaviour {
	void OnTriggerExit(Collider outro){
		Destroy (outro.gameObject);
		
	}

}