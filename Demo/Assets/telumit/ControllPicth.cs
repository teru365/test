using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Leap;
using Leap.Unity;
//指で摘むとオブジェクトが手と連動し,離すと連動を解除する
public class ControllPicth : MonoBehaviour {

	public GameObject Cube;
	public GameObject a;
	public GameObject b;
	public GameObject c;

	Controller controller;
	Frame frame ;
	List<Hand> hands ;
	Hand fristHand;
	float pinch;

	// Use this for initialization
	void Start () {
		controller = new Controller ();	

	}

	// Update is called once per frame
	void FixedUpdate () {

		frame = controller.Frame ();
		hands = frame.Hands;
		if (frame.Hands.Count > 0) 
		{
			fristHand = hands [0];
		}

		pinch = fristHand.PinchStrength;

		if (pinch > 0.5f) {
			Cube.transform.parent = this.transform;
			Cube.GetComponent<Rigidbody> ().useGravity = false;
			b.transform.parent = this.transform;
			b.GetComponent<Rigidbody> ().useGravity = false;
			c.transform.parent = this.transform;
			c.GetComponent<Rigidbody> ().useGravity = false;
			a.transform.parent = this.transform;
			a.GetComponent<Rigidbody> ().useGravity = false;
		} else if (pinch < 0.3) {
			Cube.transform.parent = null;
			Cube.GetComponent<Rigidbody> ().useGravity = true;
			b.transform.parent = null;
			b.GetComponent<Rigidbody> ().useGravity = true;
			c.transform.parent = null;
			c.GetComponent<Rigidbody> ().useGravity = true;
			a.transform.parent = null;
			a.GetComponent<Rigidbody> ().useGravity = true;
		}
	}
}
