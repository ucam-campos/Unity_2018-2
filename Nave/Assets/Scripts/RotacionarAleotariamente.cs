using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotacionarAleotariamente : MonoBehaviour {
	private Rigidbody componeteRb;
	public int forca=0;


	void Start () {
		componeteRb = GetComponent <Rigidbody> ();
		componeteRb.AddTorque (Random.insideUnitCircle * forca);
	}
	

}
