﻿using UnityEngine;
using System.Collections;

public class block : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter(Collision collision){
		if (collision.gameObject.tag == "ball") {
			Destroy (this.gameObject);
		}
	}
}
