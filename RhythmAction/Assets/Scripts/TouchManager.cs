using UnityEngine;
using System.Collections;

public class TouchManager : MonoBehaviour {

	public GameObject leftNote;
	public GameObject rightNote;
	public GameObject track;
	public Transform leftSpawn;
	public Transform rightSpawn;
	
	// Update is called once per frame
	void Update () {

		if(Input.GetMouseButtonDown(0)){
			GameObject leftClone;
			leftClone = Instantiate(leftNote, leftSpawn.position, Quaternion.identity) as GameObject;
			leftClone.transform.parent = track.transform;
		}

		if(Input.GetMouseButtonDown(1)){
			GameObject rightClone;
			rightClone = Instantiate(rightNote, rightSpawn.position, Quaternion.identity) as GameObject;
			rightClone.transform.parent = track.transform;
		}
	
	}
}
