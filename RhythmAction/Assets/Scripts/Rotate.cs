using UnityEngine;
using System.Collections;

public class Rotate : MonoBehaviour {


	public GameObject leftArm;
	public GameObject rightArm;

	void Update () {
		if(Input.GetMouseButtonDown(0)){
			leftArm.SendMessage("Left");
		}
		if(Input.GetMouseButtonUp(0)){
			leftArm.SendMessage("Left1");
		}
		if(Input.GetMouseButtonDown(1)){
			rightArm.SendMessage("Right");
		}
		if(Input.GetMouseButtonUp(1)){
			leftArm.SendMessage("Right1");
		}

	
	}
}
