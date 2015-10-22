using UnityEngine;
using System.Collections;

public class PressSwitch : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter (Collider other){
		if(other.gameObject.CompareTag ("RightNote")  || other.gameObject.CompareTag ("LeftNote")){
			other.SendMessage("Clickable");
		}
	}
}
