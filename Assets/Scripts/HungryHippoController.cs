using UnityEngine;
using System.Collections;

public class HungryHippoController : MonoBehaviour {

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

		this.transform.position = this.transform.position - new Vector3(.02f, .01f, .01f);

	}
}