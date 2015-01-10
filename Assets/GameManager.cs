using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GameManager : MonoBehaviour {

	public GameObject player;
	public GameObject endPoint;
	public Text gameOverText;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		if (player.transform.position.z > endPoint.transform.position.z){
			gameOverText.text = "Victory!";
			player.SetActive(false);
		} else if (!player.activeSelf){
			gameOverText.text = "Game Over!";
		}
	}
}
