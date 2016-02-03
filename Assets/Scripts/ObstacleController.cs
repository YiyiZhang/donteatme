using UnityEngine;
using System.Collections;

public class ObstacleController : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		this.transform.position = this.transform.position - new Vector3(.01f, 0, 0);

	}
}
