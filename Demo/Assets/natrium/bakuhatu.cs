using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class bakuhatu : MonoBehaviour {

	public ParticleSystem hitEffect;
	private ParticleSystem.EmissionModule hitEffectEmission;
	public Text ctext;
	public Text dtext;
	public Text etext;
	// Use this for initialization
	void Start () {
		hitEffectEmission = hitEffect.emission;
		hitEffectEmission.enabled = false;//炎のエフェクト
		dtext.gameObject.SetActive (true);
		etext.gameObject.SetActive (true);
	}

	// Update is called once per frame
	void Update () {

	}
	void OnTriggerEnter(Collider other){
		if (other.tag == "cube") {
			StartCoroutine ("bom");
		}
	}
	IEnumerator bom(){
		yield return new WaitForSeconds(5.0f);
		hitEffectEmission.enabled = true;
		dtext.gameObject.SetActive (false);
		ctext.gameObject.SetActive (true);
		yield return bom2 ();
	}
	IEnumerator bom2(){
		yield return new WaitForSeconds (5.0f);
		SceneManager.LoadScene ("DEMO");
	}
}
