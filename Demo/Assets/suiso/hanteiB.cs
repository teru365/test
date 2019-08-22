using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hanteiB : MonoBehaviour {
	public Renderer cube;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnTriggerEnter(Collider other){
		if(other.tag == "cube"){
			cube.enabled = true;
		}}
}
