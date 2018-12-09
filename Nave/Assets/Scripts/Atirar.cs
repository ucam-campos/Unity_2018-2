using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Atirar : MonoBehaviour {
	
	public float frequenciaDisparo = 0.4f;
	private float proximoDisparo = 0;
    public GameObject tiro;
    private AudioSource somDisparo;

    void Start()
    {
        somDisparo = GetComponent<AudioSource>();
    }


    void Update () {
		if (Input.GetButton("Fire1") && Time.time >= proximoDisparo) {
			proximoDisparo = Time.time + frequenciaDisparo;
			Instantiate (tiro, transform);
            Instantiate(tiro, new Vector3(transform.position.x + 0.4f, transform.position.y, transform.position.z + 0.8f), transform.rotation);
            Instantiate(tiro, new Vector3(transform.position.x - 0.4f, transform.position.y, transform.position.z + 0.8f), transform.rotation);
            somDisparo.Play();
        }
	}
}
