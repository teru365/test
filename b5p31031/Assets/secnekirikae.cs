using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class secnekirikae : MonoBehaviour {

	// Use this for initialization
	void Start () {
		StartCoroutine ("ido");
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	//5秒待ってから移動
	IEnumerator ido(){
	yield return new WaitForSeconds (5.0f);
	SceneManager.LoadScene ("Title");
}
}
