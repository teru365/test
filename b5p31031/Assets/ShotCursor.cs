using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShotCursor : MonoBehaviour {
	//音
	public AudioClip audioClip;
	AudioSource audioSource;
	//
	public GameObject obj1;
	public GameObject obj2;
	public GameObject obj3;
	public GameObject obj4;
	//カーソルに適用するテクスチャ
	[SerializeField]
	private Texture2D cursor;

	// Use this for initialization
	void Start () {
		//カーソルを自前のカーソルに変更
		Cursor.SetCursor (cursor, new Vector2 (cursor.width / 2, cursor.height / 2), CursorMode.ForceSoftware);
		audioSource = gameObject.GetComponent<AudioSource> ();
		audioSource.clip = audioClip;
	}
	
	// Update is called once per frame
	void Update () {
		//マウスの左クリックで撃つ
		if(Input.GetButtonDown("Fire1")){
			Shot();
			audioSource.PlayOneShot (audioClip);
	}
}
	//敵を撃つ
	public void Shot(){
		Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);
		RaycastHit hit;
		if (Physics.Raycast (ray, out hit, 100f, LayerMask.GetMask ("Enemy"))) {
			if (hit.collider.gameObject.name == "Cube")
				obj1.SendMessage("dmg1");
			if (hit.collider.gameObject.name == "Cube1")
				obj2.SendMessage("dmg2");
			if (hit.collider.gameObject.name == "Cube3")
				obj3.SendMessage("dmg3");
			if (hit.collider.gameObject.name == "Cube4")
				obj4.SendMessage("dmg4");
		}
	}
}
