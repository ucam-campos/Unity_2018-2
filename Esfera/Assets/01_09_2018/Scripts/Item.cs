using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour {

	void Update () {
		transform.Rotate (new Vector3(0.5f, 0.25f, 0.75f));		
	}
}
