using UnityEngine;
using System.Collections;

public class Obstacle2Controller : MonoBehaviour {

	//Controls security guard

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

<<<<<<< HEAD:Assets/Scripts/Obstacle2Controller.cs
		this.transform.position = this.transform.position - new Vector3(0.05f, Random.Range (-0.012f, 0.012f));
=======
		this.transform.position = this.transform.position - new Vector3(0.05f, Random.Range (-0.01f, 0.01f));
>>>>>>> d94327e0b4a9bfb150114bc0054c17ecc0897314:Assets/Scripts/Obstacle2Controller.cs

		//this.transform.position = this.transform.position - new Vector3(Random.Range(.01f,.3f), 0, 0);

	}
}
