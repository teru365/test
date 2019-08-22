using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class water4 : MonoBehaviour {

	private AudioSource sound01;
	public Text Atext;
	// Use this for initialization
	void Start () {
		sound01 = GetComponent<AudioSource> ();
		Atext.enabled = false;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnTriggerEnter(Collider other){
		if (other.tag == "AB") {
			sound01.PlayOneShot (sound01.clip);
			Atext.enabled = true;
			StartCoroutine ("bom");
		}
	}
	IEnumerator bom (){
		yield return new WaitForSeconds (5.0f);
		SceneManager.LoadScene ("DEMO");
	}
}
