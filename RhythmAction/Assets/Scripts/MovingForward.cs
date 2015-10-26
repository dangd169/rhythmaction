using UnityEngine;
using System.Collections;

public class MovingForward : MonoBehaviour {

	public float speed = -1;
	public AudioSource song;
	Rigidbody rb;

	void Start () {
		song.Play();
		rb= GetComponent<Rigidbody>();
	}

	void FixedUpdate () {
		rb.velocity = new Vector3(0, 0, speed);
	}
}
