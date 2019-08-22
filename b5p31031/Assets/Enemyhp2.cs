using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemyhp2 : MonoBehaviour {
	//Cube2の体力
	private int hp2 = 2;
	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

	}
	//ダメージ,0で破壊
	public void dmg2(){
		hp2 -= 1;
		if(hp2==0)
			Destroy (gameObject);
	}
}
