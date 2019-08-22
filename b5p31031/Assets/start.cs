using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class start : MonoBehaviour {
	//音
	public AudioClip audioClip;
	AudioSource audioSource;
	//カーソルに使用するテクスチャ
	[SerializeField]
	private Texture2D cursor;

	// Use this for initialization
	void Start () {
		//カーソルを自前のカーソルに変更
		Cursor.SetCursor (cursor, new Vector2 
			(cursor.width / 2, cursor.height / 2), CursorMode.ForceSoftware);
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
	void Shot(){
		Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);
		RaycastHit hit;

		if (Physics.Raycast (ray, out hit, 100f, LayerMask.GetMask ("Enemy"))) {
			Destroy(hit.collider.gameObject);

		}
	}
}

