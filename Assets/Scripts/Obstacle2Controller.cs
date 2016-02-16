using UnityEngine;
using System.Collections;

public class Obstacle2Controller : MonoBehaviour {

	//Controls security guard

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		this.transform.position = this.transform.position - new Vector3(0.05f, Random.Range (-0.01f, 0.01f));

		//this.transform.position = this.transform.position - new Vector3(Random.Range(.01f,.3f), 0, 0);

	}
}
