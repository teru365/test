using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemyhp4 : MonoBehaviour {
	//Cube4の体力
	private int hp4 = 7;
	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

	}
	//ダメージ,0で破壊
	public void dmg4(){
		hp4 -= 1;
		if(hp4==0)
			Destroy (gameObject);
	}
}
