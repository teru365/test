using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class flame : MonoBehaviour {

	public ParticleSystem hitEffect;
	private ParticleSystem.EmissionModule hitEffectEmission;
	public ParticleSystem hitEffect2;
	private ParticleSystem.EmissionModule hitEffectEmission2;
	public Renderer Magnesium;
	public Renderer Smoke;
	public Renderer Sparks;
	public Text atext;
	public Text btext;
	public Text ctext;
	// Use this for initialization
	void Start () {
		hitEffectEmission = hitEffect.emission;
		hitEffectEmission.enabled = false;//マグネシウムの閃光
		hitEffectEmission2 = hitEffect2.emission;
		hitEffectEmission2.enabled = false;//粉末状に火が入った時に出る火柱
		Smoke.enabled = false;
		Sparks.enabled = false;
		btext.gameObject.SetActive (true);

	}

	// Update is called once per frame
	void Update () {

	}
	void OnTriggerEnter(Collider other){
		if (other.gameObject.tag == "mag") {
			btext.gameObject.SetActive (false);
			StartCoroutine ("bom");
		}
	}
	IEnumerator bom(){
		yield return new WaitForSeconds(1.0f);
		hitEffectEmission.enabled = true;
		yield return bom2 ();
		Magnesium.enabled = false;
	}
	IEnumerator bom2(){
		yield return new WaitForSeconds (5.0f);
		hitEffectEmission.enabled = false;
		hitEffectEmission2.enabled = true;
		Smoke.enabled = true;
		Sparks.enabled = true;
		yield return bom3 ();
	}
		IEnumerator bom3(){
		yield return new WaitForSeconds (2.0f);
		Smoke.enabled = false;
		Sparks.enabled = false;
		ctext.gameObject.SetActive (false);
		atext.gameObject.SetActive (true);
		yield return bom4 ();
	}
	IEnumerator bom4(){
		yield return new WaitForSeconds (5.0f);
		SceneManager.LoadScene ("DEMO");
	}
}
