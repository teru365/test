using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemyhp1 : MonoBehaviour {
	//Cube1の体力
	private int hp1 = 3;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	//ダメージ,0で破壊
	public void dmg1(){
		hp1 -= 1;
		if(hp1==0)
		Destroy (gameObject);
	}
}
