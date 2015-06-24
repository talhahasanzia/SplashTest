using UnityEngine;
using System.Collections;

public class NewBehaviourScript : MonoBehaviour {

	public Rigidbody rg;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetKey (KeyCode.UpArrow)) {
			rg.AddForce(-5,0,0);
		
		
		}
	
	}
}
