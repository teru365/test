using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tukamu : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnTriggerStay(Collider other){
		if (other.tag == "mati") {
			other.transform.parent = gameObject.transform;
		}
	}
}
