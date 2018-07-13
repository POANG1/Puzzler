using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingRestart : MonoBehaviour {

	public GameObject camera;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		transform.position = camera.transform.position;
		Vector3 temp = transform.position;
		temp.z += 0.6f;
		temp.y -= 0.98f;
		transform.position = temp;
	}
}
