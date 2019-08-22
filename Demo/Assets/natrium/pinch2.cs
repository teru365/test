using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Leap;
using Leap.Unity;

public class pinch2 : MonoBehaviour {

	public GameObject Cube;
	public GameObject a;
	public GameObject b;


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
			a.transform.parent = this.transform;
			a.GetComponent<Rigidbody> ().useGravity = false;
			b.transform.parent = this.transform;
		} else if (pinch < 0.3) {
			Cube.transform.parent = null;
			Cube.GetComponent<Rigidbody> ().useGravity = true;
			a.transform.parent = null;
			a.GetComponent<Rigidbody> ().useGravity = true;
			b.transform.parent = null;
		}
	}
}