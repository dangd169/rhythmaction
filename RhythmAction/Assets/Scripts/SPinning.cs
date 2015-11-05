using UnityEngine;
using System.Collections;

public class SPinning : MonoBehaviour {

	float angle = 360.0f; 
	float time = 4.0f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.RotateAround(transform.position, Vector3.up, angle * Time.deltaTime / time);
	}
}
