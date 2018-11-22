using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoverInimigo : MonoBehaviour {
    public Transform target;
	private Vector3 movimentoVector = Vector3.zero;
    public float speed;

	void Start() { 
		movimentoVector = (target.position - transform.position).normalized * speed;
	}

	void Update()
    {
        float step = speed * Time.deltaTime;
		transform.position += movimentoVector * step;
    }
}
