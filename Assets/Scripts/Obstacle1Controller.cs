using UnityEngine;
using System.Collections;

public class Obstacle1Controller : MonoBehaviour {

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		
			this.transform.position = this.transform.position - new Vector3 (Random.Range (.02f, .07f), .01f, .01f);
		}
		
}