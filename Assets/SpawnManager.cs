using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class SpawnManager : MonoBehaviour {

	public GameObject Bus;
	public GameObject[] SpawnPoints;
	public int SpawnInterval1;
	public int SpawnInterval2;
	public int SpawnInterval3a;
	public int SpawnInterval3b;
	public int SpawnInterval3;
	public int SpawnInterval4;

	public static float LastBus1; // this will handle bus 1 and bus 4
	public static float LastBus2;
	public static float LastBus3;
	public static float LastBus4;

	GameObject bus1;
	GameObject bus2;
	GameObject bus3;
	GameObject bus4;
	GameObject bus5;

	// Use this for initialization
	void Start () {
		LastBus1 = 0;
		LastBus2 = 0;
		LastBus3 = 0;
		LastBus4 = 0;
		SpawnInterval3 = Random.Range(SpawnInterval3a, SpawnInterval3b);
	}
	
	// Update is called once per frame
	void Update () {
		// Spawn at different spawn points at different time intervals

		if (Time.time - LastBus1 > SpawnInterval1){
			//Random.Range(0, SpawnPoints.Length - 1)
			bus1 = Instantiate(Bus, SpawnPoints[0].transform.position, Quaternion.identity) as GameObject;
			Bus mono1 = bus1.GetComponent(typeof(Bus)) as Bus;
			mono1.Reverse = false;

			LastBus1 = Time.time;
		}

		if (Time.time - LastBus2 > SpawnInterval2) {
			bus2 = Instantiate(Bus, SpawnPoints[1].transform.position, Quaternion.identity) as GameObject;
			Bus mono2 = bus2.GetComponent(typeof(Bus)) as Bus;
			mono2.Reverse = false;
			LastBus2 = Time.time;
		}

		if (Time.time - LastBus3 > SpawnInterval3) {
			bus3 = Instantiate(Bus, SpawnPoints[2].transform.position, Quaternion.identity) as GameObject;
			Bus mono3 = bus3.GetComponent(typeof(Bus)) as Bus;
			mono3.Reverse = false;
			LastBus3 = Time.time;

			SpawnInterval3 = Random.Range(SpawnInterval3a, SpawnInterval3b);
		}

		if (Time.time - LastBus4 > SpawnInterval4) {
			bus4 = Instantiate(Bus, SpawnPoints[3].transform.position, Quaternion.identity) as GameObject;
			bus4.transform.Rotate(Vector3.up * Time.deltaTime, Space.World);
			Bus mono4 = bus4.GetComponent(typeof(Bus)) as Bus;
			mono4.Reverse = true;
			LastBus4 = Time.time;

		}
	
	}
}
