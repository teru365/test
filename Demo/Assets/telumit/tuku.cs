using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tuku : MonoBehaviour {
	public Renderer fire;
	// Use this for initialization
	void Start () {
		fire.enabled = false;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnTriggerStay(Collider other){
		if (other.gameObject.tag == "bone2") {
			fire.enabled = true;
		}
		}
	void OnTriggerExit(Collider other){
		fire.enabled = false;
	}
	}
