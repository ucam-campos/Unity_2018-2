using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestruirAoSair : MonoBehaviour {

	void OnTriggerExit (Collider outro) {
		Destroy (outro.gameObject);
	}
}
