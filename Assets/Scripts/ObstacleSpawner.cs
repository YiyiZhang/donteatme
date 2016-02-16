using UnityEngine;
using System.Collections;

public class ObstacleSpawner : MonoBehaviour {

	public GameObject object2Spawn;
	public float spawnRate;

	// Use this for initialization
	void Start () {
			
			InvokeRepeating ("Spawn", Random.Range (0.1f, 0.8f), Random.Range (3f, 5f));
	}

	void Spawn () {
		
			Instantiate (object2Spawn);

	}

}
