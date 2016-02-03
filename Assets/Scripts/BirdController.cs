using UnityEngine;
using UnityEngine.SceneManagement;

public class BirdController : MonoBehaviour {

	public Rigidbody2D rbodyToAddForcesTo; //public means we have access to it

	// Use this for initialization
	void Start () {//magic method, means Unity calls it for us
		
	}
	
	// Update is called once per frame
	void Update () {//magic method, means Unity calls it for us
		//if (Input.anyKeyDown) {
			//rbodyToAddForcesTo.AddForce (new Vector2 (0, 200));
			//robodyToAddForcesTo.AddForce (new Vector2 (0, 1)*500);
		//}

		//if (Input.GetMouseButtonUp (0)) {
			//rbodyToAddForcesTo.AddForce (new Vector2 (0, 100));
		//}

		if (Input.GetKeyDown("space")) {
			rbodyToAddForcesTo.velocity = new Vector2 (0, 0);
			rbodyToAddForcesTo.AddForce (new Vector2 (0, 1)*50);
		}
	}

	void OnCollisionEnter2D(Collision2D c){//when this object hits another object, Unity looks for a method called OnCollisionEnter2D
		//Collision2D c is a parameter/argument/input
		if (c.gameObject.tag == "Obstacle"){
			print(c.gameObject.name);//P = property, M = method (in auto-fill)
			print("RESTART");
			SceneManager.LoadScene(0);
		}
		//print ("\nhi\n");
		//print ("\"hi");
	}

	//check if it's an obstacle

	//restart scene
}
