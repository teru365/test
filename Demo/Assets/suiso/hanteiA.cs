using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hanteiA : MonoBehaviour {
	public int Cube=10;
	public Renderer mizu;
	public Renderer mizu1;
	void Start () {
		mizu.enabled = false;
		mizu1.enabled = false;
	}

	// Update is called once per frame
	void Update () {

	}
	void OnTriggerStay(Collider other){
		if (other.gameObject.tag == "Cube") {
			StartCoroutine ("damage");
			if (Cube == 6) {
				mizu.enabled = true;
			}	
			if (Cube == 4) {
				mizu1.enabled = true;
			}	
		}
	}
	IEnumerator damage(){
		Cube -= 1;
		GetComponent<CapsuleCollider>().enabled = false;
		yield return new WaitForSeconds(1.0f);
		GetComponent<CapsuleCollider>().enabled = true;
		Debug.Log ("ダメージ");
	}
}
