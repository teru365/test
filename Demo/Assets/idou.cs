using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class idou : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	//手が触れたらテルミット反応の実験に行く
	void OnTriggerEnter(Collider other) {
		if (other.gameObject.tag == "bone2") {
			SceneManager.LoadScene ("telumit");
		}
	}
}
