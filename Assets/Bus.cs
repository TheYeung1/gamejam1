using UnityEngine;
using System.Collections;

public class Bus : MonoBehaviour {

	public float Speed;
	public bool Reverse;

	CharacterController controller;

	// Use this for initialization
	void Start () {
		controller = this.GetComponent<CharacterController>();
	}
	
	// Update is called once per frame
	void Update () {
		//controller.Move (this.transform.forward * Speed);
		if (Reverse) {
			this.transform.Translate (Vector3.right * Time.deltaTime * Speed);
		} else {
			this.transform.Translate (Vector3.left * Time.deltaTime * Speed);
		}

	}

	void FixedUpdate(){

	}
}
