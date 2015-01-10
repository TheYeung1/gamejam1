using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {


	CharacterController controller;
	// Use this for initialization
	void Start () {
		this.controller = this.GetComponent<CharacterController>();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void FixedUpdate(){
		this.transform.Rotate(new Vector3(0, Input.GetAxis("Horizontal"), 0));
		controller.Move(this.transform.forward * Input.GetAxis("Vertical"));
	}
}
