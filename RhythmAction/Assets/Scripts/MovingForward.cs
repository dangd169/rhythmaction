using UnityEngine;
using System.Collections;

public class MovingForward : MonoBehaviour {

	public float speed = 10f;

	void Start () {

	}

	void Update () {

		transform.position -= transform.forward * Time.deltaTime * speed;

	}
}
