using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameClearController : MonoBehaviour {

	//配列(同じ種類の複数のデータを収納するための箱を作る
	private GameObject[] enemyObjects;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		//Enemyというタグが付いているオブジェクトのデータを箱の中に入れる
		enemyObjects = GameObject.FindGameObjectsWithTag("Enemy");

		//データの入った箱の数をコンソール画面に表示する
		print(enemyObjects.Length);

		//データの入った箱のデータが0になったとき
		if (enemyObjects.Length == 0) {

			//ゲームクリアシーンに移動する.
			SceneManager.LoadScene("clear");
		}
	}
}
