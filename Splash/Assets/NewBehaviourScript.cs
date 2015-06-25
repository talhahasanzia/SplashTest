using UnityEngine;
using System.Collections;

public class NewBehaviourScript : MonoBehaviour {

	public Rigidbody rg;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {



		if (Input.GetKey (KeyCode.UpArrow) && (rg.velocity.x<5) ){
			rg.AddForce(5,0,0);
		
		
		}
		Debug.Log ("Speed is: " + rg.velocity);

		if (rg.velocity.x > 5)
			rg.velocity = new Vector3 (5, rg.velocity.y, rg.velocity.z);

	
	}
}
