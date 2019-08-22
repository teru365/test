using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tukanai : MonoBehaviour {
	public GameObject cube;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnTriggerExit(Collider other){
		if (other.tag != "bone2" && other.tag != "bone3") {
			cube.transform.parent = null;
		}
	}
}
