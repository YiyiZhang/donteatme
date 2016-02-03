using UnityEngine;
using System.Collections;

public class KirbyController : MonoBehaviour {

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

		this.transform.position = this.transform.position - new Vector3(.02f, 0, 0);

	}
}