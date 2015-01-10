using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class SpawnManager : MonoBehaviour {

	public GameObject Bus;
	public GameObject[] SpawnPoints;
	public int SpawnInterval;

	public static float LastBus;

	// Use this for initialization
	void Start () {
		LastBus = 0;
	}
	
	// Update is called once per frame
	void Update () {
		if (Time.time - LastBus > SpawnInterval){
			//Random.Range(0, SpawnPoints.Length - 1)
			int point = Random.Range(0, SpawnPoints.Length);
			Debug.Log(point);
			Instantiate(Bus, SpawnPoints[point].transform.position, Quaternion.identity);
			LastBus = Time.time;
		}
	
	}
}
