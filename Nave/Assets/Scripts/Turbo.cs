using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turbo : MonoBehaviour {
	
	
	public GameObject propulsor;
	// Use this for initialization
	void Start () {
		Instantiate (propulsor ,transform);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
