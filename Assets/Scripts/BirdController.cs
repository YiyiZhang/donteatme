using UnityEngine;
using UnityEngine.SceneManagement;

public class BirdController : MonoBehaviour {

	public Rigidbody2D rbodyToAddForcesTo; //public means we have access to it
	public float speed;

	// Use this for initialization
	void Start () {//magic method, means Unity calls it for us
		
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetKeyDown("up")) {
			rbodyToAddForcesTo.velocity = new Vector2 (0, 0);
			rbodyToAddForcesTo.AddForce (new Vector2 (0, 1)*speed);
		}

		if (Input.GetKeyDown("down")) {
			rbodyToAddForcesTo.velocity = new Vector2 (0, 0);
			rbodyToAddForcesTo.AddForce (new Vector2 (0, -1)*speed);
		}

		if (Input.GetKeyDown("left")) {
			rbodyToAddForcesTo.velocity = new Vector2 (0, 0);
			rbodyToAddForcesTo.AddForce (new Vector2 (-1, 0)*speed);
		}

		if (Input.GetKeyDown("right")) {
			rbodyToAddForcesTo.velocity = new Vector2 (0, 0);
			rbodyToAddForcesTo.AddForce (new Vector2 (1, 0)*speed);
		}

	}

	void OnCollisionEnter2D(Collision2D c){
		if (c.gameObject.tag == "Obstacle"){
			print(c.gameObject.name);
			print("RESTART");
			SceneManager.LoadScene(0);
		}
	}

	//check if it's an obstacle

	//restart scene
}
