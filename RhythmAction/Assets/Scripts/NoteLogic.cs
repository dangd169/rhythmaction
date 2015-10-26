using UnityEngine;
using System.Collections;

public class NoteLogic : MonoBehaviour {

	// Use this for initialization

	bool click = false;

	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		if(click){
			if(Input.GetMouseButtonDown(1) && this.gameObject.CompareTag ("RightNote")){
				Destroy(this.gameObject);
			}
			if(Input.GetMouseButtonDown(0) && this.gameObject.CompareTag ("LeftNote")){
				Destroy(this.gameObject);
			}
		}
	
	}

	void Clickable () {
		click = true;
	}

	void NotClickable () {
		click = false;
	}
}
