using UnityEngine;
using System.Collections;

public class Bus : MonoBehaviour {

	public float Speed;

	CharacterController controller;

	// Use this for initialization
	void Start () {
		controller = this.GetComponent<CharacterController>();
	}
	
	// Update is called once per frame
	void Update () {
		//controller.Move (this.transform.forward * Speed);
		this.transform.Translate(Vector3.left * Time.deltaTime * Speed);
	}

	void FixedUpdate(){

	}
}
