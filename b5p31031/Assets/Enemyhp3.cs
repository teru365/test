using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemyhp3 : MonoBehaviour {
	//Cube3の体力
	private int hp3 = 2;
	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

	}
	//ダメージ,0で破壊
	public void dmg3(){
		hp3 -= 1;
		if(hp3==0)
			Destroy (gameObject);
	}
}
