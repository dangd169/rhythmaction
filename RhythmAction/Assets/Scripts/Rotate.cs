using UnityEngine;
using System.Collections;

public class Rotate : MonoBehaviour {


	public MeshRenderer leftArm;
	public MeshRenderer rightArm;
	
	void Update (){

		if(Input.GetMouseButtonDown(0)){
			leftArm.enabled = false;
		}
		if(Input.GetMouseButtonUp(0)){
			leftArm.enabled = true;
		}
		if(Input.GetMouseButtonDown(1)){
			rightArm.enabled = false;
		}
		if(Input.GetMouseButtonUp(1)){
			rightArm.enabled = true;
		}
	}
		
}
