using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hantei2 : MonoBehaviour {
	public Renderer ren;
	// Use this for initialization
	void Start () {
		ren.enabled = false;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnTriggerEnter(Collider other){
		if (other.gameObject.name == "Cube") {
			ren.enabled = true;
		}
	}
}
